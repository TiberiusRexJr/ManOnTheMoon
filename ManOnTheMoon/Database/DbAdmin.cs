using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManOnTheMoon.Database;
using ManOnTheMoon.Models;
namespace ManOnTheMoon.Database
{
    public class DbAdmin: DbQueryProducts
    {
        #region Variables
        private DataBaseModelsDataContext db = new DataBaseModelsDataContext();
        #endregion

        #region Methods
        public new void Errorhead(Exception e)
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
        public Product  CreateProduct(Product product)
        {
            Product returnProduct = null;
            if (product == null)
            {
                return returnProduct;
            }
            try
            {
                db.Products.InsertOnSubmit(product);
                db.SubmitChanges();
                returnProduct = product;
                
            }
            catch (Exception e)
            {
                Errorhead(e);


            }
            return returnProduct;
        }
        public Category CreateCategory(Category category)
        {
            Category responseCategory = null;
            if (category == null)
            {
                return responseCategory;
            }
            try
            {
                db.Categories.InsertOnSubmit(category);
                db.SubmitChanges();
                responseCategory = category;
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseCategory;
        }
        public Brand CreateBrand(Brand brand)
        {
            Brand responseBrand = null;
            if (brand == null)
            {
                return responseBrand;
            }
            try
            {
                db.Brands.InsertOnSubmit(brand);
                db.SubmitChanges();
                responseBrand = brand;
            }
            catch (Exception e)
            {
                Errorhead(e);

            }
            return responseBrand;
        }
        public Product_Image CreateProductImageRecord(Product_Image product_Images)
        {
            Product_Image product_Image2Response = null;
            if(product_Images==null)
            {
                return product_Image2Response;
            }
            try
            {
                db.Product_Images.InsertOnSubmit(product_Images);
                db.SubmitChanges();
                product_Image2Response = product_Images;
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return product_Image2Response;
        }

        #endregion

        #region Update
            public bool UpdateProduct(Product product)
            {
            bool status = false;

            if(product==null)
            {
                return status;
            }
            try
            {
                Product currentProduct = db.Products.Where(p => p.Id == product.Id).FirstOrDefault();
                currentProduct.Name = product.Name;
                currentProduct.Description = product.Description;
                currentProduct.Upc = product.Upc;
                currentProduct.Brand = product.Brand;
                currentProduct.Length = product.Length;
                currentProduct.Weight = product.Weight;
                currentProduct.Height = product.Height;
                currentProduct.Cost = product.Cost;
                currentProduct.Retail_Price = product.Retail_Price;
                currentProduct.Sale_Price = product.Sale_Price;
                currentProduct.Stock_Quantity = product.Stock_Quantity;
                currentProduct.Category = product.Category;
                currentProduct.Sub_Category = product.Sub_Category;
                currentProduct.On_Sale_Status = product.On_Sale_Status;
                currentProduct.Width = product.Width;
                db.SubmitChanges();
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return status;
            }
            public bool UpdateCategory(Category category)
            {
            bool status = false;
            if(category==null)
            { return status; }
            try
            {

                var oldCategory = db.Categories.Where(c => c.Id == category.Id).FirstOrDefault();
                oldCategory.Name = category.Name;
                db.SubmitChanges();
                status = true;

            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return status;
            }
            public bool UpdateBrand(Brand brand)
            {
                bool status = false;
                if(brand==null)

                { return status; }
            try
            {
                Brand oldBrand = db.Brands.Where(b => b.Id == brand.Id).FirstOrDefault();
                oldBrand.Name = brand.Name;

                db.SubmitChanges();
                status = true;
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return status;
            }
            public bool UpdateProductImages(Product_Image product_Images)
            {
                bool status = false;
                try
                {
                Product_Image currentImageRecord = db.Product_Images.Where(p => p.Id == product_Images.Id).FirstOrDefault();
                currentImageRecord.Product_Id = product_Images.Product_Id;
                currentImageRecord.Product_Image_1 = product_Images.Product_Image_1;
                currentImageRecord.Product_Image_2 = product_Images.Product_Image_2;
                currentImageRecord.Product_Image_3 = product_Images.Product_Image_3;
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

        #region RetrieveBy
        public Product GetproductById(int id)
        {
            Product product = null;

            if (String.IsNullOrEmpty(id.ToString()))
            { return product; }
            try
            {
                var query = db.Products.ToList();
                product = query.Where(p => p.Id == id).FirstOrDefault();
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return product;
        }
        #endregion

        #region Delete
            public bool DeleteProduct(Product p)
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
            public bool DeleteBrand(Brand brand)
            {
            bool status = false;
            if(brand==null)
            { return status; }
            try
            {
                Brand oldBrand = db.Brands.Where(b => b.Id == brand.Id).FirstOrDefault();

                status = true;
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return status;
            }
            public bool DeleteCategory(Category category)
            {
            bool status = false;
            if(category==null)
            {
                return status;
            }
            try
            {
                db.Categories.DeleteOnSubmit(category);
                db.SubmitChanges();
                status = true;
            }
            catch(Exception e)
            {
                Errorhead(e);
            }
            return status;
            }
            public bool DeleteAllProductImages(Product_Image product_Images)
            {
            bool status = false;
            try
            {
                db.Product_Images.DeleteOnSubmit(product_Images);
                db.SubmitChanges();
                status = true;
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return status;
            }
        #endregion

        //upWork.com
    }
}