﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Midterm
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EET321_2_Mon")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEET321_2_Mon(EET321_2_Mon instance);
    partial void UpdateEET321_2_Mon(EET321_2_Mon instance);
    partial void DeleteEET321_2_Mon(EET321_2_Mon instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Midterm.Properties.Settings.Default.EET321_2_MonConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EET321_2_Mon> EET321_2_Mons
		{
			get
			{
				return this.GetTable<EET321_2_Mon>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EET321_2_Mon")]
	public partial class EET321_2_Mon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _DateTime;
		
		private string _Person;
		
		private string _A;
		
		private string _B;
		
		private string _C;
		
		private string _D;
		
		private string _E;
		
		private string _F;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDateTimeChanging(System.DateTime value);
    partial void OnDateTimeChanged();
    partial void OnPersonChanging(string value);
    partial void OnPersonChanged();
    partial void OnAChanging(string value);
    partial void OnAChanged();
    partial void OnBChanging(string value);
    partial void OnBChanged();
    partial void OnCChanging(string value);
    partial void OnCChanged();
    partial void OnDChanging(string value);
    partial void OnDChanged();
    partial void OnEChanging(string value);
    partial void OnEChanged();
    partial void OnFChanging(string value);
    partial void OnFChanged();
    #endregion
		
		public EET321_2_Mon()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Person", DbType="NChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Person
		{
			get
			{
				return this._Person;
			}
			set
			{
				if ((this._Person != value))
				{
					this.OnPersonChanging(value);
					this.SendPropertyChanging();
					this._Person = value;
					this.SendPropertyChanged("Person");
					this.OnPersonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_A", DbType="NChar(20)")]
		public string A
		{
			get
			{
				return this._A;
			}
			set
			{
				if ((this._A != value))
				{
					this.OnAChanging(value);
					this.SendPropertyChanging();
					this._A = value;
					this.SendPropertyChanged("A");
					this.OnAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B", DbType="NChar(20)")]
		public string B
		{
			get
			{
				return this._B;
			}
			set
			{
				if ((this._B != value))
				{
					this.OnBChanging(value);
					this.SendPropertyChanging();
					this._B = value;
					this.SendPropertyChanged("B");
					this.OnBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C", DbType="NChar(20)")]
		public string C
		{
			get
			{
				return this._C;
			}
			set
			{
				if ((this._C != value))
				{
					this.OnCChanging(value);
					this.SendPropertyChanging();
					this._C = value;
					this.SendPropertyChanged("C");
					this.OnCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D", DbType="NChar(20)")]
		public string D
		{
			get
			{
				return this._D;
			}
			set
			{
				if ((this._D != value))
				{
					this.OnDChanging(value);
					this.SendPropertyChanging();
					this._D = value;
					this.SendPropertyChanged("D");
					this.OnDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_E", DbType="NChar(20)")]
		public string E
		{
			get
			{
				return this._E;
			}
			set
			{
				if ((this._E != value))
				{
					this.OnEChanging(value);
					this.SendPropertyChanging();
					this._E = value;
					this.SendPropertyChanged("E");
					this.OnEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_F", DbType="NChar(20)")]
		public string F
		{
			get
			{
				return this._F;
			}
			set
			{
				if ((this._F != value))
				{
					this.OnFChanging(value);
					this.SendPropertyChanging();
					this._F = value;
					this.SendPropertyChanged("F");
					this.OnFChanged();
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
