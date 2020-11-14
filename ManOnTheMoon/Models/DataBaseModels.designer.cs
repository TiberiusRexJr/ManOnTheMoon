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

namespace ManOnTheMoon.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ManOnTheMoonDB")]
	public partial class DataBaseModelsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    #endregion
		
		public DataBaseModelsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ManOnTheMoonDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseModelsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private int _Upc;
		
		private string _Brand;
		
		private System.Nullable<double> _Length;
		
		private System.Nullable<double> _Weight;
		
		private System.Nullable<double> _Height;
		
		private System.Nullable<decimal> _Cost;
		
		private System.Nullable<decimal> _Retail_Price;
		
		private System.Nullable<decimal> _Sale_Price;
		
		private int _Stock_Quantity;
		
		private string _Category;
		
		private string _Sub_Category;
		
		private bool _On_Sale_Status;
		
		private System.Nullable<double> _Width;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnUpcChanging(int value);
    partial void OnUpcChanged();
    partial void OnBrandChanging(string value);
    partial void OnBrandChanged();
    partial void OnLengthChanging(System.Nullable<double> value);
    partial void OnLengthChanged();
    partial void OnWeightChanging(System.Nullable<double> value);
    partial void OnWeightChanged();
    partial void OnHeightChanging(System.Nullable<double> value);
    partial void OnHeightChanged();
    partial void OnCostChanging(System.Nullable<decimal> value);
    partial void OnCostChanged();
    partial void OnRetail_PriceChanging(System.Nullable<decimal> value);
    partial void OnRetail_PriceChanged();
    partial void OnSale_PriceChanging(System.Nullable<decimal> value);
    partial void OnSale_PriceChanged();
    partial void OnStock_QuantityChanging(int value);
    partial void OnStock_QuantityChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnSub_CategoryChanging(string value);
    partial void OnSub_CategoryChanged();
    partial void OnOn_Sale_StatusChanging(bool value);
    partial void OnOn_Sale_StatusChanged();
    partial void OnWidthChanging(System.Nullable<double> value);
    partial void OnWidthChanged();
    #endregion
		
		public Product()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Upc", DbType="Int NOT NULL")]
		public int Upc
		{
			get
			{
				return this._Upc;
			}
			set
			{
				if ((this._Upc != value))
				{
					this.OnUpcChanging(value);
					this.SendPropertyChanging();
					this._Upc = value;
					this.SendPropertyChanged("Upc");
					this.OnUpcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Brand", DbType="VarChar(100)")]
		public string Brand
		{
			get
			{
				return this._Brand;
			}
			set
			{
				if ((this._Brand != value))
				{
					this.OnBrandChanging(value);
					this.SendPropertyChanging();
					this._Brand = value;
					this.SendPropertyChanged("Brand");
					this.OnBrandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Length", DbType="Float")]
		public System.Nullable<double> Length
		{
			get
			{
				return this._Length;
			}
			set
			{
				if ((this._Length != value))
				{
					this.OnLengthChanging(value);
					this.SendPropertyChanging();
					this._Length = value;
					this.SendPropertyChanged("Length");
					this.OnLengthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Float")]
		public System.Nullable<double> Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Height", DbType="Float")]
		public System.Nullable<double> Height
		{
			get
			{
				return this._Height;
			}
			set
			{
				if ((this._Height != value))
				{
					this.OnHeightChanging(value);
					this.SendPropertyChanging();
					this._Height = value;
					this.SendPropertyChanged("Height");
					this.OnHeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Retail_Price", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Retail_Price
		{
			get
			{
				return this._Retail_Price;
			}
			set
			{
				if ((this._Retail_Price != value))
				{
					this.OnRetail_PriceChanging(value);
					this.SendPropertyChanging();
					this._Retail_Price = value;
					this.SendPropertyChanged("Retail_Price");
					this.OnRetail_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sale_Price", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Sale_Price
		{
			get
			{
				return this._Sale_Price;
			}
			set
			{
				if ((this._Sale_Price != value))
				{
					this.OnSale_PriceChanging(value);
					this.SendPropertyChanging();
					this._Sale_Price = value;
					this.SendPropertyChanged("Sale_Price");
					this.OnSale_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stock_Quantity", DbType="Int NOT NULL")]
		public int Stock_Quantity
		{
			get
			{
				return this._Stock_Quantity;
			}
			set
			{
				if ((this._Stock_Quantity != value))
				{
					this.OnStock_QuantityChanging(value);
					this.SendPropertyChanging();
					this._Stock_Quantity = value;
					this.SendPropertyChanged("Stock_Quantity");
					this.OnStock_QuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(100)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sub_Category", DbType="VarChar(50)")]
		public string Sub_Category
		{
			get
			{
				return this._Sub_Category;
			}
			set
			{
				if ((this._Sub_Category != value))
				{
					this.OnSub_CategoryChanging(value);
					this.SendPropertyChanging();
					this._Sub_Category = value;
					this.SendPropertyChanged("Sub_Category");
					this.OnSub_CategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_On_Sale_Status", DbType="Bit NOT NULL")]
		public bool On_Sale_Status
		{
			get
			{
				return this._On_Sale_Status;
			}
			set
			{
				if ((this._On_Sale_Status != value))
				{
					this.OnOn_Sale_StatusChanging(value);
					this.SendPropertyChanging();
					this._On_Sale_Status = value;
					this.SendPropertyChanged("On_Sale_Status");
					this.OnOn_Sale_StatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Width", DbType="Float")]
		public System.Nullable<double> Width
		{
			get
			{
				return this._Width;
			}
			set
			{
				if ((this._Width != value))
				{
					this.OnWidthChanging(value);
					this.SendPropertyChanging();
					this._Width = value;
					this.SendPropertyChanged("Width");
					this.OnWidthChanged();
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
