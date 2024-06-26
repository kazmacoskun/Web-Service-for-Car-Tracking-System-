﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Track_EmergencyCall_Contact")]
	public partial class AracTakip_UzakDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLocking(Locking instance);
    partial void UpdateLocking(Locking instance);
    partial void DeleteLocking(Locking instance);
    partial void InsertTrack_PortPlaka(Track_PortPlaka instance);
    partial void UpdateTrack_PortPlaka(Track_PortPlaka instance);
    partial void DeleteTrack_PortPlaka(Track_PortPlaka instance);
    partial void InsertTrack_LocationInf(Track_LocationInf instance);
    partial void UpdateTrack_LocationInf(Track_LocationInf instance);
    partial void DeleteTrack_LocationInf(Track_LocationInf instance);
    #endregion
		
		public AracTakip_UzakDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Track_EmergencyCall_ContactConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakip_UzakDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakip_UzakDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakip_UzakDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakip_UzakDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Locking> Lockings
		{
			get
			{
				return this.GetTable<Locking>();
			}
		}
		
		public System.Data.Linq.Table<Track_PortPlaka> Track_PortPlakas
		{
			get
			{
				return this.GetTable<Track_PortPlaka>();
			}
		}
		
		public System.Data.Linq.Table<Track_LocationInf> Track_LocationInfs
		{
			get
			{
				return this.GetTable<Track_LocationInf>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Locking")]
	public partial class Locking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _S_ID;
		
		private string _Sirket_ADI;
		
		private string _Kullanıcı_ADI;
		
		private string _Kullanici_SIFRE;
		
		private string _Sirket_PORT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnS_IDChanging(int value);
    partial void OnS_IDChanged();
    partial void OnSirket_ADIChanging(string value);
    partial void OnSirket_ADIChanged();
    partial void OnKullanıcı_ADIChanging(string value);
    partial void OnKullanıcı_ADIChanged();
    partial void OnKullanici_SIFREChanging(string value);
    partial void OnKullanici_SIFREChanged();
    partial void OnSirket_PORTChanging(string value);
    partial void OnSirket_PORTChanged();
    #endregion
		
		public Locking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int S_ID
		{
			get
			{
				return this._S_ID;
			}
			set
			{
				if ((this._S_ID != value))
				{
					this.OnS_IDChanging(value);
					this.SendPropertyChanging();
					this._S_ID = value;
					this.SendPropertyChanged("S_ID");
					this.OnS_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sirket_ADI", DbType="NChar(30) NOT NULL", CanBeNull=false)]
		public string Sirket_ADI
		{
			get
			{
				return this._Sirket_ADI;
			}
			set
			{
				if ((this._Sirket_ADI != value))
				{
					this.OnSirket_ADIChanging(value);
					this.SendPropertyChanging();
					this._Sirket_ADI = value;
					this.SendPropertyChanged("Sirket_ADI");
					this.OnSirket_ADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kullanıcı_ADI", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Kullanıcı_ADI
		{
			get
			{
				return this._Kullanıcı_ADI;
			}
			set
			{
				if ((this._Kullanıcı_ADI != value))
				{
					this.OnKullanıcı_ADIChanging(value);
					this.SendPropertyChanging();
					this._Kullanıcı_ADI = value;
					this.SendPropertyChanged("Kullanıcı_ADI");
					this.OnKullanıcı_ADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kullanici_SIFRE", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Kullanici_SIFRE
		{
			get
			{
				return this._Kullanici_SIFRE;
			}
			set
			{
				if ((this._Kullanici_SIFRE != value))
				{
					this.OnKullanici_SIFREChanging(value);
					this.SendPropertyChanging();
					this._Kullanici_SIFRE = value;
					this.SendPropertyChanged("Kullanici_SIFRE");
					this.OnKullanici_SIFREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sirket_PORT", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string Sirket_PORT
		{
			get
			{
				return this._Sirket_PORT;
			}
			set
			{
				if ((this._Sirket_PORT != value))
				{
					this.OnSirket_PORTChanging(value);
					this.SendPropertyChanging();
					this._Sirket_PORT = value;
					this.SendPropertyChanged("Sirket_PORT");
					this.OnSirket_PORTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Track_PortPlaka")]
	public partial class Track_PortPlaka : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlakaID;
		
		private string _PortNumber;
		
		private string _Plaka;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlakaIDChanging(int value);
    partial void OnPlakaIDChanged();
    partial void OnPortNumberChanging(string value);
    partial void OnPortNumberChanged();
    partial void OnPlakaChanging(string value);
    partial void OnPlakaChanged();
    #endregion
		
		public Track_PortPlaka()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlakaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PlakaID
		{
			get
			{
				return this._PlakaID;
			}
			set
			{
				if ((this._PlakaID != value))
				{
					this.OnPlakaIDChanging(value);
					this.SendPropertyChanging();
					this._PlakaID = value;
					this.SendPropertyChanged("PlakaID");
					this.OnPlakaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PortNumber", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string PortNumber
		{
			get
			{
				return this._PortNumber;
			}
			set
			{
				if ((this._PortNumber != value))
				{
					this.OnPortNumberChanging(value);
					this.SendPropertyChanging();
					this._PortNumber = value;
					this.SendPropertyChanged("PortNumber");
					this.OnPortNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plaka", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string Plaka
		{
			get
			{
				return this._Plaka;
			}
			set
			{
				if ((this._Plaka != value))
				{
					this.OnPlakaChanging(value);
					this.SendPropertyChanging();
					this._Plaka = value;
					this.SendPropertyChanged("Plaka");
					this.OnPlakaChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Track_LocationInf")]
	public partial class Track_LocationInf : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LocationInf;
		
		private string _PortNumber;
		
		private string _Plaka;
		
		private string _Latitude;
		
		private string _LatPos;
		
		private string _Longitude;
		
		private string _LonPos;
		
		private string _Speed;
		
		private string _Course;
		
		private string _EmergencyCall;
		
		private string _Contact;
		
		private System.DateTime _DateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLocationInfChanging(int value);
    partial void OnLocationInfChanged();
    partial void OnPortNumberChanging(string value);
    partial void OnPortNumberChanged();
    partial void OnPlakaChanging(string value);
    partial void OnPlakaChanged();
    partial void OnLatitudeChanging(string value);
    partial void OnLatitudeChanged();
    partial void OnLatPosChanging(string value);
    partial void OnLatPosChanged();
    partial void OnLongitudeChanging(string value);
    partial void OnLongitudeChanged();
    partial void OnLonPosChanging(string value);
    partial void OnLonPosChanged();
    partial void OnSpeedChanging(string value);
    partial void OnSpeedChanged();
    partial void OnCourseChanging(string value);
    partial void OnCourseChanged();
    partial void OnEmergencyCallChanging(string value);
    partial void OnEmergencyCallChanged();
    partial void OnContactChanging(string value);
    partial void OnContactChanged();
    partial void OnDateTimeChanging(System.DateTime value);
    partial void OnDateTimeChanged();
    #endregion
		
		public Track_LocationInf()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationInf", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LocationInf
		{
			get
			{
				return this._LocationInf;
			}
			set
			{
				if ((this._LocationInf != value))
				{
					this.OnLocationInfChanging(value);
					this.SendPropertyChanging();
					this._LocationInf = value;
					this.SendPropertyChanged("LocationInf");
					this.OnLocationInfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PortNumber", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string PortNumber
		{
			get
			{
				return this._PortNumber;
			}
			set
			{
				if ((this._PortNumber != value))
				{
					this.OnPortNumberChanging(value);
					this.SendPropertyChanging();
					this._PortNumber = value;
					this.SendPropertyChanged("PortNumber");
					this.OnPortNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plaka", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Plaka
		{
			get
			{
				return this._Plaka;
			}
			set
			{
				if ((this._Plaka != value))
				{
					this.OnPlakaChanging(value);
					this.SendPropertyChanging();
					this._Plaka = value;
					this.SendPropertyChanged("Plaka");
					this.OnPlakaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LatPos", DbType="NChar(2)")]
		public string LatPos
		{
			get
			{
				return this._LatPos;
			}
			set
			{
				if ((this._LatPos != value))
				{
					this.OnLatPosChanging(value);
					this.SendPropertyChanging();
					this._LatPos = value;
					this.SendPropertyChanged("LatPos");
					this.OnLatPosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LonPos", DbType="NChar(2)")]
		public string LonPos
		{
			get
			{
				return this._LonPos;
			}
			set
			{
				if ((this._LonPos != value))
				{
					this.OnLonPosChanging(value);
					this.SendPropertyChanging();
					this._LonPos = value;
					this.SendPropertyChanged("LonPos");
					this.OnLonPosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="NChar(10)")]
		public string Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				if ((this._Speed != value))
				{
					this.OnSpeedChanging(value);
					this.SendPropertyChanging();
					this._Speed = value;
					this.SendPropertyChanged("Speed");
					this.OnSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course", DbType="NChar(15)")]
		public string Course
		{
			get
			{
				return this._Course;
			}
			set
			{
				if ((this._Course != value))
				{
					this.OnCourseChanging(value);
					this.SendPropertyChanging();
					this._Course = value;
					this.SendPropertyChanged("Course");
					this.OnCourseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmergencyCall", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string EmergencyCall
		{
			get
			{
				return this._EmergencyCall;
			}
			set
			{
				if ((this._EmergencyCall != value))
				{
					this.OnEmergencyCallChanging(value);
					this.SendPropertyChanging();
					this._EmergencyCall = value;
					this.SendPropertyChanged("EmergencyCall");
					this.OnEmergencyCallChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contact", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string Contact
		{
			get
			{
				return this._Contact;
			}
			set
			{
				if ((this._Contact != value))
				{
					this.OnContactChanging(value);
					this.SendPropertyChanging();
					this._Contact = value;
					this.SendPropertyChanged("Contact");
					this.OnContactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime NOT NULL")]
		public System.DateTime DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
