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
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertBrand(Brand instance);
    partial void UpdateBrand(Brand instance);
    partial void DeleteBrand(Brand instance);
    partial void InsertProduct_Image(Product_Image instance);
    partial void UpdateProduct_Image(Product_Image instance);
    partial void DeleteProduct_Image(Product_Image instance);
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
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Brand> Brands
		{
			get
			{
				return this.GetTable<Brand>();
			}
		}
		
		public System.Data.Linq.Table<Product_Image> Product_Images
		{
			get
			{
				return this.GetTable<Product_Image>();
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
		
		private EntitySet<Product_Image> _Product_Images;
		
		private EntityRef<Category> _Category1;
		
		private EntityRef<Brand> _Brand1;
		
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
			this._Product_Images = new EntitySet<Product_Image>(new Action<Product_Image>(this.attach_Product_Images), new Action<Product_Image>(this.detach_Product_Images));
			this._Category1 = default(EntityRef<Category>);
			this._Brand1 = default(EntityRef<Brand>);
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
					if (this._Brand1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
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
					if (this._Category1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Product_Image", Storage="_Product_Images", ThisKey="Id", OtherKey="Product_Id")]
		public EntitySet<Product_Image> Product_Images
		{
			get
			{
				return this._Product_Images;
			}
			set
			{
				this._Product_Images.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Category1", ThisKey="Category", OtherKey="Name", IsForeignKey=true)]
		public Category Category1
		{
			get
			{
				return this._Category1.Entity;
			}
			set
			{
				Category previousValue = this._Category1.Entity;
				if (((previousValue != value) 
							|| (this._Category1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category1.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Category1.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._Category = value.Name;
					}
					else
					{
						this._Category = default(string);
					}
					this.SendPropertyChanged("Category1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Brand_Product", Storage="_Brand1", ThisKey="Brand", OtherKey="Name", IsForeignKey=true)]
		public Brand Brand1
		{
			get
			{
				return this._Brand1.Entity;
			}
			set
			{
				Brand previousValue = this._Brand1.Entity;
				if (((previousValue != value) 
							|| (this._Brand1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Brand1.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Brand1.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._Brand = value.Name;
					}
					else
					{
						this._Brand = default(string);
					}
					this.SendPropertyChanged("Brand1");
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
		
		private void attach_Product_Images(Product_Image entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Product_Images(Product_Image entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Category()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Product", Storage="_Products", ThisKey="Name", OtherKey="Category")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Category1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Brands")]
	public partial class Brand : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Product> _Products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Brand()
		{
			this._Products = new EntitySet<Product>(new Action<Product>(this.attach_Products), new Action<Product>(this.detach_Products));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Brand_Product", Storage="_Products", ThisKey="Name", OtherKey="Brand")]
		public EntitySet<Product> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Brand1 = this;
		}
		
		private void detach_Products(Product entity)
		{
			this.SendPropertyChanging();
			entity.Brand1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product_Images")]
	public partial class Product_Image : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Product_Id;
		
		private string _Product_Image_1;
		
		private string _Product_Image_2;
		
		private string _Product_Image_3;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnProduct_IdChanging(System.Nullable<int> value);
    partial void OnProduct_IdChanged();
    partial void OnProduct_Image_1Changing(string value);
    partial void OnProduct_Image_1Changed();
    partial void OnProduct_Image_2Changing(string value);
    partial void OnProduct_Image_2Changed();
    partial void OnProduct_Image_3Changing(string value);
    partial void OnProduct_Image_3Changed();
    #endregion
		
		public Product_Image()
		{
			this._Product = default(EntityRef<Product>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Id", DbType="Int")]
		public System.Nullable<int> Product_Id
		{
			get
			{
				return this._Product_Id;
			}
			set
			{
				if ((this._Product_Id != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProduct_IdChanging(value);
					this.SendPropertyChanging();
					this._Product_Id = value;
					this.SendPropertyChanged("Product_Id");
					this.OnProduct_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Image_1", DbType="VarChar(MAX)")]
		public string Product_Image_1
		{
			get
			{
				return this._Product_Image_1;
			}
			set
			{
				if ((this._Product_Image_1 != value))
				{
					this.OnProduct_Image_1Changing(value);
					this.SendPropertyChanging();
					this._Product_Image_1 = value;
					this.SendPropertyChanged("Product_Image_1");
					this.OnProduct_Image_1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Image_2", DbType="VarChar(MAX)")]
		public string Product_Image_2
		{
			get
			{
				return this._Product_Image_2;
			}
			set
			{
				if ((this._Product_Image_2 != value))
				{
					this.OnProduct_Image_2Changing(value);
					this.SendPropertyChanging();
					this._Product_Image_2 = value;
					this.SendPropertyChanged("Product_Image_2");
					this.OnProduct_Image_2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Image_3", DbType="VarChar(MAX)")]
		public string Product_Image_3
		{
			get
			{
				return this._Product_Image_3;
			}
			set
			{
				if ((this._Product_Image_3 != value))
				{
					this.OnProduct_Image_3Changing(value);
					this.SendPropertyChanging();
					this._Product_Image_3 = value;
					this.SendPropertyChanged("Product_Image_3");
					this.OnProduct_Image_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Product_Image", Storage="_Product", ThisKey="Product_Id", OtherKey="Id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Product_Images.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Product_Images.Add(this);
						this._Product_Id = value.Id;
					}
					else
					{
						this._Product_Id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Product");
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
