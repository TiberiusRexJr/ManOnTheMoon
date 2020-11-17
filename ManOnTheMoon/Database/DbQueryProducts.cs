﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.WebSockets;
using ManOnTheMoon.Models;

namespace ManOnTheMoon.Database
{
    public class DbAdminCrud
    {
        string DatabaseURL = "../App_Data/ManOnTheMoonDB.mdf";
        private DataBaseModelsDataContext db = new DataBaseModelsDataContext();

        #region Constructor
            public DbAdminCrud()
        {
            try
            {

            DataContext db = new DataContext(DatabaseURL);
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
        #endregion
        #region Methods
            public void Errorhead(Exception e)
            {
            Console.WriteLine("----------Error----------: ");
            Console.WriteLine("Error Message: " + e.Message);
            Console.WriteLine("ErrorType: " + e.GetType().ToString());
            Console.WriteLine("Exception Instance: " + e.InnerException.ToString());
            Console.WriteLine("Error Method: " + e.TargetSite);//Gets Erroneius Method
            Console.WriteLine("Error Object/Application: " + e.Source.ToString());
            Console.WriteLine("Error StackTrace: " + e.StackTrace);
        }   
        #region CRUD
        //Create
        #region Create
            public bool CreateProduct(Product product)
            {
                bool status = false;
                if(product==null)
                {
                    return status;
                }
                try
                {
                db.Products.InsertOnSubmit(product);
                    db.SubmitChanges();
                    status = true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("----------Error----------: ");
                    Console.WriteLine("Error Message: "+e.Message);
                    Console.WriteLine("ErrorType: "+e.GetType().ToString());
                    Console.WriteLine("Exception Instance: "+e.InnerException.ToString());
                    Console.WriteLine("Error Method: " + e.TargetSite);//Gets Erroneius Method
                    Console.WriteLine("Error Object/Application: " + e.Source.ToString());
                    Console.WriteLine("Error StackTrace: " + e.StackTrace);


                status = false;
                }
                return status;
            }
            public bool CreateCategory(Category category)
            {
                bool status = false;
                if (category == null)
                {
                    return status;
                }
                try
                {
                    db.Categories.InsertOnSubmit(category);
                    db.SubmitChanges();
                    status = true;
                }
            catch (Exception e)
            {
                Console.WriteLine("----------Error----------: ");
                Console.WriteLine("Error Message: " + e.Message);
                Console.WriteLine("ErrorType: " + e.GetType().ToString());
                Console.WriteLine("Exception Instance: " + e.InnerException.ToString());
                Console.WriteLine("Error Method: " + e.TargetSite);//Gets Erroneius Method
                Console.WriteLine("Error Object/Application: " + e.Source.ToString());
                Console.WriteLine("Error StackTrace: " + e.StackTrace);


                status = false;
            }
            return status;
            }
            public bool CreateBrand(Brand brand)
            {
                bool status = false;
                if (brand == null)
                {
                    return status;
                }
                try
                {
                    db.Brands.InsertOnSubmit(brand);
                    db.SubmitChanges();
                    status = true;
                }
            catch (Exception e)
            {
                Console.WriteLine("----------Error----------: ");
                Console.WriteLine("Error Message: " + e.Message);
                Console.WriteLine("ErrorType: " + e.GetType().ToString());
                Console.WriteLine("Exception Instance: " + e.InnerException.ToString());
                Console.WriteLine("Error Method: " + e.TargetSite);//Gets Erroneius Method
                Console.WriteLine("Error Object/Application: " + e.Source.ToString());
                Console.WriteLine("Error StackTrace: " + e.StackTrace);


                status = false;
            }
            return status;
            }

        #endregion

        //ReTrieve
        #region Retrieve
        #region All
        public List<Product> GetAllProducts()
            {
            List<Product> Products = new List<Product>();
            try
            {
                Products = db.Products.ToList();
            }
            catch (Exception e)
            {
                this.Errorhead(e);
            }
            return Products;
            }
        public List<Brand> GetAllBrands()
        {
            List<Brand> Brands = new List<Brand>();
            try
            {
                Brands = db.Brands.ToList();
            }
            catch (Exception e)
            {
                this.Errorhead(e);
            }
            return Brands;
        }
        public List<Category> GetAllCategories()
        {
            List<Category> categories= new List<Category>();
            try
            {
                categories = db.Categories.ToList();
            }
            catch (Exception e)
            {
                this.Errorhead(e);
            }
            return categories;
        }
        #endregion


        #region ByPricePoint 
            public List<Product> RetrieveProductsByPriceOrder(int mode)
            {
            List<Product> products = new List<Product>();

            try
            {

                switch(mode)
                {
            
                case 1:products = db.Products.OrderBy(p => p.Retail_Price).ToList();
                    break;
                case 2:products = db.Products.OrderByDescending(p => p.Retail_Price).ToList();
                    break;
                }
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
                return products;
            }

            public List<Product> RetrieveProductsByPriceRange(int mode)
            {
            List<Product> products = new List<Product>();
            try
            {
                switch (mode)
                {
                    case 1:
                        products = db.Products.Where(p => p.Retail_Price > 0 && p.Retail_Price <= 30).OrderBy(p => p.Retail_Price).ToList();
                        break;
                    case 2:
                        products = db.Products.Where(p => p.Retail_Price > 30 && p.Retail_Price <= 80).OrderBy(p => p.Retail_Price).ToList();
                        ;
                        break;
                    case 3:
                        products = db.Products.Where(p => p.Retail_Price > 130 && p.Retail_Price <= 180).OrderBy(p => p.Retail_Price).ToList();

                        ;
                        break;
                    case 4:
                        products = db.Products.Where(p => p.Retail_Price > 180 && p.Retail_Price <= 230).OrderBy(p => p.Retail_Price).ToList();

                        ;
                        break;
                    case 5:
                        products = db.Products.Where(p => p.Retail_Price > 230).OrderBy(p => p.Retail_Price).ToList();

                        ;
                        break;
                }
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
                return products;
            }
        #endregion

        #region ByCategory

            public List<Product> RetrieveProductByCategory(string Category)
            {
                List<Product> productsByCategory = new List<Product>() ;
            try
            {
                productsByCategory=db.Products.Where(p=>p.Category==Category).OrderBy(p=>p.Name).ToList();

            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return productsByCategory;
                 

            }
        #endregion
        //Update
        #region Update

        #endregion
        //Delete
        #region Delete

        #endregion
        #endregion
        #endregion
        #endregion
    }
}