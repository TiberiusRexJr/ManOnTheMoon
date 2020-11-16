using System;
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

        #endregion
        //Update
        #region Update

        #endregion
        //Delete
        #region Delete

        #endregion
        #endregion
        #endregion
    }
}