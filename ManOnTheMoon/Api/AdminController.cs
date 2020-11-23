﻿using ManOnTheMoon.Database;
using ManOnTheMoon.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace ManOnTheMoon.Api
{
    public class AdminController : ApiController
    {
        #region Variables
        DbAdmin db = new DbAdmin();
        #endregion

        #region Errorhandlers
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

        #region ResponseClasses
        public class Response<TReturnData> : IHttpActionResult
        {
            #region Properties
            public TReturnData returnData { get; set; }
            public HttpStatusCode status { get; set; }
            public string ReasonPhrase { get; set; }
            #endregion



            #region IImplementation
            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {

                var data = JsonSerializer.Serialize(returnData);
                var response = new HttpResponseMessage()
                {
                    Content = new StringContent(data, Encoding.UTF8, "application/json"),
                    StatusCode = status,
                    ReasonPhrase = ReasonPhrase


                };

                return Task.FromResult(response);
            }
            #endregion
        }
        #endregion

        #region Post
        public Response<Product> PostProduct([FromBody] Product product)
        {
            Response<Product> responseMessage = new Response<Product>();
            try
            {
                var DbResponse = db.CreateProduct(product);

                if (DbResponse == null)
                {
                    responseMessage.returnData = null;
                    responseMessage.ReasonPhrase = "Database Responsed With Null";
                    responseMessage.status = HttpStatusCode.Conflict;
                }
                else
                {
                    responseMessage.returnData = DbResponse;
                    responseMessage.ReasonPhrase = "SuccessFully Inserted";
                    responseMessage.status = HttpStatusCode.Created;
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<Category> PostCategory([FromBody] Category category)
        {
            Response<Category> responseMessage = new Response<Category>();
            try
            {
                var DbResponse = db.CreateCategory(category);

                if (DbResponse == null)
                {
                    responseMessage.returnData = null;
                    responseMessage.ReasonPhrase = "Database Responsed With Null";
                    responseMessage.status = HttpStatusCode.Conflict;
                }
                else
                {
                    responseMessage.returnData = DbResponse;
                    responseMessage.ReasonPhrase = "SuccessFully Inserted";
                    responseMessage.status = HttpStatusCode.Created;
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;

        }
        public Response<Brand> PostBrand([FromBody] Brand brand)
        {
            Response<Brand> responseMessage = new Response<Brand>();
            try
            {
                var DbResponse = db.CreateBrand(brand);

                if (DbResponse == null)
                {
                    responseMessage.returnData = null;
                    responseMessage.ReasonPhrase = "Database Responsed With Null";
                    responseMessage.status = HttpStatusCode.Conflict;
                }
                else
                {
                    responseMessage.returnData = DbResponse;
                    responseMessage.ReasonPhrase = "SuccessFully Inserted";
                    responseMessage.status = HttpStatusCode.Created;
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<Product_Image> PostProductImages([FromBody] Product_Image product_Images)
        {

            {
                Response<Product_Image> responseMessage = new Response<Product_Image>();
                try
                {
                    var DbResponse = db.CreateProductImageRecord(product_Images);

                    if (DbResponse == null)
                    {
                        responseMessage.returnData = null;
                        responseMessage.ReasonPhrase = "Database Responsed With Null";
                        responseMessage.status = HttpStatusCode.Conflict;
                    }
                    else
                    {
                        responseMessage.returnData = DbResponse;
                        responseMessage.ReasonPhrase = "SuccessFully Inserted";
                        responseMessage.status = HttpStatusCode.Created;
                    }
                }
                catch (Exception e)
                {
                    Errorhead(e);
                }
                return responseMessage;
            }
        }
        #endregion

        #region Put
        public Response<Product> PutProduct(Product product)
        {
            Response<Product> responseMessage = new Response<Product>();
            var dbResponse = db.UpdateProduct(product);
            try
            {

                if (dbResponse == false)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Update Failed";
                }
                else if (dbResponse == true)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.NoContent;
                    responseMessage.ReasonPhrase = "Update Succeded";
                }

            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<Category> PutCategory(Category category)
        {
            Response<Category> responseMessage = new Response<Category>();
            var dbResponse = db.UpdateCategory(category);
            try
            {

                if (dbResponse == false)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Update Failed";
                }
                else if (dbResponse == true)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.NoContent;
                    responseMessage.ReasonPhrase = "Update Succeded";
                }

            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<Brand> PutBrand(Brand brand)
        {
            Response<Brand> responseMessage = new Response<Brand>();
            var dbResponse = db.UpdateBrand(brand);
            try
            {

                if (dbResponse == false)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Update Failed";
                }
                else if (dbResponse == true)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.NoContent;
                    responseMessage.ReasonPhrase = "Update Succeded";
                }

            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<Product_Image> PutProductImages(Product_Image images)
        {
            Response<Product_Image> responseMessage = new Response<Product_Image>();
            var dbResponse = db.UpdateProductImages(images);
            try
            {

                if (dbResponse == false)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Update Failed";
                }
                else if (dbResponse == true)
                {
                    responseMessage.returnData = null;
                    responseMessage.status = HttpStatusCode.NoContent;
                    responseMessage.ReasonPhrase = "Update Succeded";
                }

            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }



        #endregion

        #region Get
        public Response<Product> GetProductById(int productId)
        {
            Response<Product> responseMessage = new Response<Product>();
            try
            {
                var DbResponse = db.GetproductById(productId);

                if (DbResponse == null)
                {
                    responseMessage.returnData = DbResponse;
                    responseMessage.status = HttpStatusCode.NotFound;
                    responseMessage.ReasonPhrase = "Requested item was Not Found";
                }
                else
                {
                    responseMessage.returnData = DbResponse;
                    responseMessage.status = HttpStatusCode.OK;
                    responseMessage.ReasonPhrase = "Requested item Found";
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;

        }
        #endregion

        #region Delete
        public Response<bool> DeleteProduct(Product product)
        {

            Response<bool> responseMessage = new Response<bool>();

            try
            {
                var databaseResponse = db.DeleteProduct(product);
                if (databaseResponse == false)
                {
                    responseMessage.returnData = false;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Failed To Delte";
                }
                else if (databaseResponse == true)
                {
                    responseMessage.returnData = true;
                    responseMessage.status = HttpStatusCode.OK;
                    responseMessage.ReasonPhrase = "Product Deleted";
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<bool> DeleteBrand(Brand brand)
        {
            Response<bool> responseMessage = new Response<bool>();
            try
            {
                var databaseResponse = db.DeleteBrand(brand);

                if (databaseResponse == false)
                {
                    responseMessage.returnData = false;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Failed To Delte";
                }
                else if (databaseResponse == true)
                {
                    responseMessage.returnData = true;
                    responseMessage.status = HttpStatusCode.OK;
                    responseMessage.ReasonPhrase = "Product Deleted";
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<bool> DeleteCategory(Category category)
        {
            Response<bool> responseMessage = new Response<bool>();

            try
            {
                var databaseResponse = db.DeleteCategory(category);

                if (databaseResponse == false)
                {
                    responseMessage.returnData = false;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Failed To Delte";
                }
                else if (databaseResponse == true)
                {
                    responseMessage.returnData = true;
                    responseMessage.status = HttpStatusCode.OK;
                    responseMessage.ReasonPhrase = "Category Deleted";
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }
        public Response<bool> DeleteProductImages(Product_Image product_Image)
        {

            Response<bool> responseMessage = new Response<bool>();

            try
            {
                var databaseResponse = db.DeleteAllProductImages(product_Image);

                if (databaseResponse == false)
                {
                    responseMessage.returnData = false;
                    responseMessage.status = HttpStatusCode.Conflict;
                    responseMessage.ReasonPhrase = "Failed To Delte";
                }
                else if (databaseResponse == true)
                {
                    responseMessage.returnData = true;
                    responseMessage.status = HttpStatusCode.OK;
                    responseMessage.ReasonPhrase = "Product Images Deleted";
                }
            }
            catch (Exception e)
            {
                Errorhead(e);
            }
            return responseMessage;
        }

        #endregion

    }

}

