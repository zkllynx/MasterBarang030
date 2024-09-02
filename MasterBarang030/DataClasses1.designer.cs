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

namespace MasterBarang030
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuizMahasiswa")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_barang(tbl_barang instance);
    partial void Updatetbl_barang(tbl_barang instance);
    partial void Deletetbl_barang(tbl_barang instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::MasterBarang030.Properties.Settings.Default.QuizMahasiswaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<tbl_barang> tbl_barangs
		{
			get
			{
				return this.GetTable<tbl_barang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_barang")]
	public partial class tbl_barang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_barang;
		
		private string _nama_barang;
		
		private int _harga;
		
		private int _stok;
		
		private string _nama_supplier;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_barangChanging(int value);
    partial void Onid_barangChanged();
    partial void Onnama_barangChanging(string value);
    partial void Onnama_barangChanged();
    partial void OnhargaChanging(int value);
    partial void OnhargaChanged();
    partial void OnstokChanging(int value);
    partial void OnstokChanged();
    partial void Onnama_supplierChanging(string value);
    partial void Onnama_supplierChanged();
    #endregion
		
		public tbl_barang()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_barang", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_barang
		{
			get
			{
				return this._id_barang;
			}
			set
			{
				if ((this._id_barang != value))
				{
					this.Onid_barangChanging(value);
					this.SendPropertyChanging();
					this._id_barang = value;
					this.SendPropertyChanged("id_barang");
					this.Onid_barangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_barang", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string nama_barang
		{
			get
			{
				return this._nama_barang;
			}
			set
			{
				if ((this._nama_barang != value))
				{
					this.Onnama_barangChanging(value);
					this.SendPropertyChanging();
					this._nama_barang = value;
					this.SendPropertyChanged("nama_barang");
					this.Onnama_barangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_harga", DbType="Int NOT NULL")]
		public int harga
		{
			get
			{
				return this._harga;
			}
			set
			{
				if ((this._harga != value))
				{
					this.OnhargaChanging(value);
					this.SendPropertyChanging();
					this._harga = value;
					this.SendPropertyChanged("harga");
					this.OnhargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stok", DbType="Int NOT NULL")]
		public int stok
		{
			get
			{
				return this._stok;
			}
			set
			{
				if ((this._stok != value))
				{
					this.OnstokChanging(value);
					this.SendPropertyChanging();
					this._stok = value;
					this.SendPropertyChanged("stok");
					this.OnstokChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama_supplier", DbType="VarChar(50)")]
		public string nama_supplier
		{
			get
			{
				return this._nama_supplier;
			}
			set
			{
				if ((this._nama_supplier != value))
				{
					this.Onnama_supplierChanging(value);
					this.SendPropertyChanging();
					this._nama_supplier = value;
					this.SendPropertyChanged("nama_supplier");
					this.Onnama_supplierChanged();
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
