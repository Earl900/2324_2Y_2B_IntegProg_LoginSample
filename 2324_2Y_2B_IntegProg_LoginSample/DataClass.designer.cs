﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2324_2Y_2B_IntegProg_LoginSample
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="2324_2B_LoginSample")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblLog(tblLog instance);
    partial void UpdatetblLog(tblLog instance);
    partial void DeletetblLog(tblLog instance);
    partial void InserttblLogin(tblLogin instance);
    partial void UpdatetblLogin(tblLogin instance);
    partial void DeletetblLogin(tblLogin instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::_2324_2Y_2B_IntegProg_LoginSample.Properties.Settings.Default._2324_2B_LoginSampleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblLog> tblLogs
		{
			get
			{
				return this.GetTable<tblLog>();
			}
		}
		
		public System.Data.Linq.Table<tblLogin> tblLogins
		{
			get
			{
				return this.GetTable<tblLogin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblLog")]
	public partial class tblLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LogID;
		
		private string _LoginID;
		
		private System.DateTime _LogDate;
		
		private EntityRef<tblLogin> _tblLogin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogIDChanging(int value);
    partial void OnLogIDChanged();
    partial void OnLoginIDChanging(string value);
    partial void OnLoginIDChanged();
    partial void OnLogDateChanging(System.DateTime value);
    partial void OnLogDateChanged();
    #endregion
		
		public tblLog()
		{
			this._tblLogin = default(EntityRef<tblLogin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LogID
		{
			get
			{
				return this._LogID;
			}
			set
			{
				if ((this._LogID != value))
				{
					this.OnLogIDChanging(value);
					this.SendPropertyChanging();
					this._LogID = value;
					this.SendPropertyChanged("LogID");
					this.OnLogIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginID", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string LoginID
		{
			get
			{
				return this._LoginID;
			}
			set
			{
				if ((this._LoginID != value))
				{
					if (this._tblLogin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoginIDChanging(value);
					this.SendPropertyChanging();
					this._LoginID = value;
					this.SendPropertyChanged("LoginID");
					this.OnLoginIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogDate", DbType="DateTime NOT NULL")]
		public System.DateTime LogDate
		{
			get
			{
				return this._LogDate;
			}
			set
			{
				if ((this._LogDate != value))
				{
					this.OnLogDateChanging(value);
					this.SendPropertyChanging();
					this._LogDate = value;
					this.SendPropertyChanged("LogDate");
					this.OnLogDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblLogin_tblLog", Storage="_tblLogin", ThisKey="LoginID", OtherKey="LoginID", IsForeignKey=true)]
		public tblLogin tblLogin
		{
			get
			{
				return this._tblLogin.Entity;
			}
			set
			{
				tblLogin previousValue = this._tblLogin.Entity;
				if (((previousValue != value) 
							|| (this._tblLogin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblLogin.Entity = null;
						previousValue.tblLogs.Remove(this);
					}
					this._tblLogin.Entity = value;
					if ((value != null))
					{
						value.tblLogs.Add(this);
						this._LoginID = value.LoginID;
					}
					else
					{
						this._LoginID = default(string);
					}
					this.SendPropertyChanged("tblLogin");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblLogin")]
	public partial class tblLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LoginID;
		
		private string _LoginPassword;
		
		private string _LoginName;
		
		private System.Nullable<System.DateTime> _LoginDate;
		
		private EntitySet<tblLog> _tblLogs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginIDChanging(string value);
    partial void OnLoginIDChanged();
    partial void OnLoginPasswordChanging(string value);
    partial void OnLoginPasswordChanged();
    partial void OnLoginNameChanging(string value);
    partial void OnLoginNameChanged();
    partial void OnLoginDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLoginDateChanged();
    #endregion
		
		public tblLogin()
		{
			this._tblLogs = new EntitySet<tblLog>(new Action<tblLog>(this.attach_tblLogs), new Action<tblLog>(this.detach_tblLogs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginID", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LoginID
		{
			get
			{
				return this._LoginID;
			}
			set
			{
				if ((this._LoginID != value))
				{
					this.OnLoginIDChanging(value);
					this.SendPropertyChanging();
					this._LoginID = value;
					this.SendPropertyChanged("LoginID");
					this.OnLoginIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginPassword", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string LoginPassword
		{
			get
			{
				return this._LoginPassword;
			}
			set
			{
				if ((this._LoginPassword != value))
				{
					this.OnLoginPasswordChanging(value);
					this.SendPropertyChanging();
					this._LoginPassword = value;
					this.SendPropertyChanged("LoginPassword");
					this.OnLoginPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LoginName
		{
			get
			{
				return this._LoginName;
			}
			set
			{
				if ((this._LoginName != value))
				{
					this.OnLoginNameChanging(value);
					this.SendPropertyChanging();
					this._LoginName = value;
					this.SendPropertyChanged("LoginName");
					this.OnLoginNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LoginDate
		{
			get
			{
				return this._LoginDate;
			}
			set
			{
				if ((this._LoginDate != value))
				{
					this.OnLoginDateChanging(value);
					this.SendPropertyChanging();
					this._LoginDate = value;
					this.SendPropertyChanged("LoginDate");
					this.OnLoginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblLogin_tblLog", Storage="_tblLogs", ThisKey="LoginID", OtherKey="LoginID")]
		public EntitySet<tblLog> tblLogs
		{
			get
			{
				return this._tblLogs;
			}
			set
			{
				this._tblLogs.Assign(value);
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
		
		private void attach_tblLogs(tblLog entity)
		{
			this.SendPropertyChanging();
			entity.tblLogin = this;
		}
		
		private void detach_tblLogs(tblLog entity)
		{
			this.SendPropertyChanging();
			entity.tblLogin = null;
		}
	}
}
#pragma warning restore 1591
