using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManOnTheMoon.Database;
using ManOnTheMoon.Models;
namespace ManOnTheMoon.Database
{
    public class DbAdmin
    {
        #region Variables
        private DataBaseModelsDataContext db = new DataBaseModelsDataContext();
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
        #endregion

        #region Create
        public bool CreateProduct(Product product)
        {
            bool status = false;
            if (product == null)
            {
                return status;
            }
            try
            {
                db.Products.InsertOnSubmit(product);
                db.SubmitChanges();
                status = true;
            }
            catch (Exception e)
            {
                ErrorHead(e);


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
                Errorhead(e);

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
                Errorhead(e);


                status = false;
            }
            return status;
        }

        #endregion

        #region RetrieveBy
        public Product productsById(int id)
        {
            Product product = new Product() ;
            try
            {
                product = db.Products.Where(p => p.Id == id).FirstOrDefault();
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return product;
        }
        #endregion

        #region Delete
            public bool DeleteById(Product p)
            {
                bool status = false;

                if(p==null)
                {
                    status = false;
                    return status;
                }   
                try
                {
                db.Products.DeleteOnSubmit(p);
                db.SubmitChanges();
                status = true;
                }
                catch(Exception e)
                {
                Errorhead(e);
                }
            return status;
            }
        #endregion


    }
}