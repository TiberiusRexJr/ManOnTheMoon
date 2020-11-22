using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ManOnTheMoon.Models;
using ManOnTheMoon.Database;
using System.Threading.Tasks;
using System.Threading;

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

            #region Constructor
            public PostResponse()
            { 

            }
            #endregion

            #region IImplementation
            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {

                var data = JsonSerializer.Serialize(returnData);
                  var response = new HttpResponseMessage()
                  {
                    Content = new StringContent(data,Encoding.UTF8, "application/json"),
                    StatusCode = status,
                    ReasonPhrase=ReasonPhrase

                    
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
                 var DbResponse=db.CreateProduct(product);

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
            catch(Exception e)
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
        public void PutProduct() { }
        public void PutCategory() { }
        public void PutBrand() { }
        public void PutProductImages() { }



        #endregion

        #region Get
            public void GetProductById(){ }
        #endregion

        #region Delete
        public void DeleteProduct() { }
        public void DeleteBrand() { }
        public void DeleteCategory() { }
        public void DeleteProductImages() { }

        #endregion

    }

}

