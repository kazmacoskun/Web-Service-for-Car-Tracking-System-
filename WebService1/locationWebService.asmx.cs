using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService1
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        public AracTakip_UzakDataContext database = new AracTakip_UzakDataContext();
        public double longitude = 0;
        double latitude = 0;
        double speed;
        string direction, yon="sabit";
        string durum,drm;
        string kontak,kntk;
        string port_num = "";

        [WebMethod]

        public string login(string sirket, string kullanici, string sifre)
        {
            try
            {
                var port_number = from a in database.Lockings
                                  where a.Sirket_ADI == sirket && a.Kullanıcı_ADI == kullanici && a.Kullanici_SIFRE == sifre
                                  select a;

                var listele = port_number.ToList();
                if (listele.Count != 0)
                {
                    port_num = listele[listele.Count() - 1].Sirket_PORT;
                    return port_num;
                }

                else
                {
                    return "hata";
                }

            }
            catch { return "hata"; }
        }

        [WebMethod]

        public List<WebService1.Track_PortPlaka> plakalar(string port)
        {            
            var plakalars = from a in database.Track_PortPlakas
                            where a.PortNumber == port
                            select a;
            var listele = plakalars.ToList();
            //listele.ToList();
            return listele;
        }

        [WebMethod]

        public List<string> sorgu(string plaka)
        {
            List<string> SorguListe = new List<string>();
            try
            {                
                string selceted = plaka;
                var plakalars = (from a in database.Track_LocationInfs
                                 where a.Plaka == selceted //&& a.DateTime.Date >= DateTime.Today // && a.DateTime.Day >= dateTimePicker1.Value.Day
                                 orderby a.LocationInf descending
                                 select a).First();

                Track_LocationInf track;
                track = plakalars;

                //var listele = track.ToList();
                int point_ind_lat = track.Latitude.IndexOf(".");

                string lat_pos_W = track.Latitude.Substring(point_ind_lat - 2);
                lat_pos_W = lat_pos_W.Replace(".", ",");
                double lat_pos = Convert.ToDouble(lat_pos_W) / 60;
                double lat_pos_2 = Convert.ToDouble(track.Latitude.Substring(0, point_ind_lat - 2));
                latitude = lat_pos_2 + lat_pos;

                SorguListe.Add(latitude.ToString());


                int point_ind_lon = track.Longitude.IndexOf(".");
                string lon_pos_W = track.Longitude.Substring(point_ind_lon - 2);
                lon_pos_W = lon_pos_W.Replace(".", ",");
                double lon_pos = Convert.ToDouble(lon_pos_W) / 60;
                double lon_pos_2 = Convert.ToDouble(track.Longitude.Substring(0, point_ind_lon - 2));
                longitude = lon_pos_2 + lon_pos;

                SorguListe.Add(longitude.ToString());

                durum = track.EmergencyCall.Trim();//acil çağrı durumunu gösteren sorgu
                kontak = track.Contact.Trim();

                speed = (Convert.ToDouble((track.Speed).Replace(".", ","))) * 1.852;

                SorguListe.Add(speed.ToString());

                if (speed < 10)
                    speed = 0;
                direction = track.Course;
                direction = direction.Trim();
                direction = direction.Replace(".", ",");
                if (Convert.ToDouble(direction) > 67 && Convert.ToDouble(direction) < 112)
                {
                    yon = "Doğu";
                }
                if (Convert.ToDouble(direction) > 247 && Convert.ToDouble(direction) < 293)//OK
                {
                    yon = "Batı";
                }
                if (Convert.ToDouble(direction) > 337 && Convert.ToDouble(direction) < 21)
                {
                    yon = "Kuzey";
                }
                if (Convert.ToDouble(direction) > 157 && Convert.ToDouble(direction) < 202)
                {
                    yon = "Güney";
                }
                if (Convert.ToDouble(direction) > 23 && Convert.ToDouble(direction) < 67)
                {
                    yon = "Kuzey-Doğu";
                }
                if (Convert.ToDouble(direction) > 293 && Convert.ToDouble(direction) < 337)
                {
                    yon = "Kuzey-Batı";
                }
                if (Convert.ToDouble(direction) > 112 && Convert.ToDouble(direction) < 157)
                {
                    yon = "Güney-Doğu";
                }
                if (Convert.ToDouble(direction) > 202 && Convert.ToDouble(direction) < 247)
                {
                    yon = "Güney-Batı";
                }
                if (durum == "0")
                {
                    drm = "normal";
                }
                if (durum == "1")
                {
                    drm = "acil";
                }
                if (kontak == "1")
                {
                    kntk = "acik";
                }
                if (kontak == "0")
                {
                    kntk = "kapali";
                }
                SorguListe.Add(drm);
                SorguListe.Add(kntk);
                SorguListe.Add(yon);
                SorguListe.Add((track.DateTime.ToString()).ToString());
            }
            catch
            {
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
            }
            return SorguListe;
        }


        [WebMethod]

        public List<WebService1.Track_LocationInf> smilasyon(string plaka, DateTime date, DateTime date2)
        {
            var plakalars = from a in database.Track_LocationInfs
                            where a.Plaka == plaka &&  a.DateTime <= date && a.DateTime>=date2
                            select a;
            var listele = plakalars.ToList();
            //listele.ToList();
            return listele;
        }

        [WebMethod]

        public List<WebService1.Track_LocationInf> smilasyon_atlamali(string plaka, DateTime date, DateTime date2, int atlama)
        {
            var plakalars = from a in database.Track_LocationInfs
                            where a.Plaka == plaka && a.DateTime <= date && a.DateTime >= date2 && a.LocationInf % atlama == 0
                            select a;
            var listele = plakalars.ToList();
            //listele.ToList();
            return listele;
        }


        //FORM2

        [WebMethod]

        public List<WebService1.Track_LocationInf> plakalar_FORM2(string plaka, DateTime date, DateTime date2)
        {
            var plakalars = from a in database.Track_LocationInfs
                            where a.Plaka == plaka && date <= a.DateTime && date2 >= a.DateTime
                            select a;
            var listele = plakalars.ToList();
            listele.ToList();
            return listele;
        }

        [WebMethod]

        public List<string> sorgu_hiz_kucuk_FORM2(string plaka, DateTime date, DateTime date2, double speed)
        {
            List<string> SorguListe = new List<string>();
            try
            {
                var plakalars = (from a in database.Track_LocationInfs
                                 where a.Plaka == plaka && date <= a.DateTime && date2 >= a.DateTime && Convert.ToDouble(a.Speed) <= speed
                                 orderby a.LocationInf descending
                                 select a).First();

                SorguListe.Add(plakalars.LocationInf.ToString());
                SorguListe.Add(plakalars.PortNumber);
                SorguListe.Add(plakalars.Plaka);
                SorguListe.Add(plakalars.Latitude);
                SorguListe.Add(plakalars.LatPos);
                SorguListe.Add(plakalars.Longitude);
                SorguListe.Add(plakalars.LonPos);
                SorguListe.Add(plakalars.Speed);
                SorguListe.Add(plakalars.Course);
                SorguListe.Add(plakalars.EmergencyCall);
                SorguListe.Add(plakalars.Contact);
                SorguListe.Add(plakalars.DateTime.ToString());
            }
            catch
            {
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add(plaka);
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
            }
            return SorguListe;           
        }

        [WebMethod]

        public List<string> sorgu_hiz_buyuk_FORM2(string plaka, DateTime date, DateTime date2, double speed)
        {
            List<string> SorguListe = new List<string>();
            try
            {
                var plakalars = (from a in database.Track_LocationInfs
                                 where a.Plaka == plaka && date <= a.DateTime && date2 >= a.DateTime && Convert.ToDouble(a.Speed) >= speed
                                 orderby a.LocationInf descending
                                 select a).First();

                SorguListe.Add(plakalars.LocationInf.ToString());
                SorguListe.Add(plakalars.PortNumber);
                SorguListe.Add(plakalars.Plaka);
                SorguListe.Add(plakalars.Latitude);
                SorguListe.Add(plakalars.LatPos);
                SorguListe.Add(plakalars.Longitude);
                SorguListe.Add(plakalars.LonPos);
                SorguListe.Add(plakalars.Speed);
                SorguListe.Add(plakalars.Course);
                SorguListe.Add(plakalars.EmergencyCall);
                SorguListe.Add(plakalars.Contact);
                SorguListe.Add(plakalars.DateTime.ToString());
            }
            catch (Exception)
            {

                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add(plaka);
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
            }


            return SorguListe;
        }


        [WebMethod]

        public List<string> sorgu_yer_FORM2(string plaka)
        {
            List<string> SorguListe = new List<string>();
            try
            {
                var plakalars = (from a in database.Track_LocationInfs
                                 where a.Plaka == plaka
                                 orderby a.LocationInf descending
                                 select a).First();

                SorguListe.Add(plakalars.LocationInf.ToString());
                SorguListe.Add(plakalars.PortNumber);
                SorguListe.Add(plakalars.Plaka);
                SorguListe.Add(plakalars.Latitude);
                SorguListe.Add(plakalars.LatPos);
                SorguListe.Add(plakalars.Longitude);
                SorguListe.Add(plakalars.LonPos);
                SorguListe.Add(plakalars.Speed);
                SorguListe.Add(plakalars.Course);
                SorguListe.Add(plakalars.EmergencyCall);
                SorguListe.Add(plakalars.Contact);
                SorguListe.Add(plakalars.DateTime.ToString());
            }
            catch (Exception)
            {
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add(plaka);
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
            }

            return SorguListe;

        }

        [WebMethod]

        public List<WebService1.Track_LocationInf> istatistik_FORM2(string plaka, DateTime date, DateTime date2)
        {
            var plakalars = from a in database.Track_LocationInfs
                            where a.Plaka == plaka && date <= a.DateTime && date2 >= a.DateTime
                            orderby a.DateTime descending
                            select a;
            var listele = plakalars.ToList();
            listele.ToList();
            return listele;
        }

        [WebMethod]

        public List<string> neredeydim_FORM2(string plaka, DateTime date)
        {
            List<string> SorguListe = new List<string>();
            try
            {
                var plakalars = (from a in database.Track_LocationInfs
                                 where a.Plaka == plaka && a.DateTime < date
                                 orderby a.LocationInf descending
                                 select a).First();

                SorguListe.Add(plakalars.LocationInf.ToString());
                SorguListe.Add(plakalars.PortNumber);
                SorguListe.Add(plakalars.Plaka);
                SorguListe.Add(plakalars.Latitude);
                SorguListe.Add(plakalars.LatPos);
                SorguListe.Add(plakalars.Longitude);
                SorguListe.Add(plakalars.LonPos);
                SorguListe.Add(plakalars.Speed);
                SorguListe.Add(plakalars.Course);
                SorguListe.Add(plakalars.EmergencyCall);
                SorguListe.Add(plakalars.Contact);
                SorguListe.Add(plakalars.DateTime.ToString());
            }
            catch (Exception)
            {

                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add(plaka);
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
                SorguListe.Add("0000.000");
            }


            return SorguListe;
        }

        [WebMethod]

        public List<WebService1.Track_LocationInf> yedekle_FORM2(DateTime date, DateTime date2)
        {
            var plakalars = from a in database.Track_LocationInfs
                            where  a.DateTime >= date  &&   a.DateTime <= date2
                            select a;
            var listele = plakalars.ToList();
            //listele.ToList();
            return listele;
        }

        private void InitializeComponent()
        {

        }

    }
}