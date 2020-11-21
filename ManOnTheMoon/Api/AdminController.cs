using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text.Json;
using ManOnTheMoon.Models;
using System.Threading.Tasks;
using System.Threading;

namespace ManOnTheMoon.Api
{
    public class AdminController : ApiController
    {
        #region Errorhandlers
        private void ErrorHead(Exception e)
        {

        }
        #endregion

        #region ResponseClasses
        public class PostResponse<TReturnData> : IHttpActionResult
        {
            #region Properties
            public TReturnData returnData { get; set; }
            public HttpRequestMessage requestMessage { get; set; }
            #endregion

            #region Constructor
            public PostResponse()
            { 

            }
            #endregion
            public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        #region Post
        public void PostProduct([FromBody] Product product)
        { }
        public void PostCategory([FromBody] Category category)
        { }
        public void PostBrand([FromBody] Brand brand)
        { }
        public void PostProductImages([FromBody] Product_Image product_Images)
        { }
        #endregion
        public string PostProduct([FromBody] Product product)
        { 
            return
        }
        public string PostCategory([FromBody] Category category )
        {
            return
        }
        public string PostBrand([FromBody] Brand brand)
        {
            return
        }
        public string PostProductImageRecord([FromBody] Product_Image product_Images)
        {

            return
        }
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

