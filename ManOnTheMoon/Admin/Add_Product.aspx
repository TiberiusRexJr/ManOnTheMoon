<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Add_Product.aspx.cs" Inherits="ManOnTheMoon.Admin.Add_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container" style="background-color: orange;">

        <h2>Add Product</h2>
        <div class="row justify-content-center" style="background-color:darkblue;">
             <div class="col-lg-6 col-md-6 bg-danger">
               <h4>Description</h4>
                 <div class="form-group d-none">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Product_Id</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for=" ">Name</label>
                    <input class="form-control py-4" id=" " type=" " placeholder="placeholder" />
                 </div>
                 <div class="form-group ">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Description</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for=" ">UPC</label>
                    <input class="form-control py-4" id=" " type=" " placeholder="placeholder" />
                 </div>
                 <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for=" ">Brand</label>
                    <select name="department" class="form-control selectpicker">
                  <option value="">Select your Department/Office</option>
                  <option>Department of Engineering</option>
                  <option>Department of Agriculture</option>
                  <option >Tourism Office</option>
                    </select>
                 </div>
            </div>
        <div class="col-lg-6 col-md-6 bg-info">
               <h4>Images</h4>

             
            <div class="file-upload-wrapper">
  <input type="file" id="input-file-now-custom-1" class="file-upload" data-default-file="https://mdbootstrap.com/img/Photos/Others/images/89.jpg" />
</div>
        </div>
    
    </div>
          <div class="row justify-content-center" style="background-color:purple;">
                
              <div class="col-lg-6 col-md-6 bg-info">
                 <h4>Dimensions</h4>
                 <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Length</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Width</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Height</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Weight</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
              </div>
              <div class="col-lg-6 col-md-6 bg-light">
                 <h4>Financial</h4>
                 <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Purchase Cost</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Retail</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">On Sale Price</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">On Sale Status</label>
                    <label class="radio-inline d-block"><input type="radio" name="optradio" checked>Option 1</label>
<label class="radio-inline"><input type="radio" name="optradio">Option 2</label>
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Stock Quantity</label>
                    <input class="form-control py-4" id="product_id " type="number" />
                 </div>
              </div>

        </div>
        <div class="row" style="background-color:purple;">
                
              <div class="col-lg-6 col-md-6 float-left bg-danger">
                 <h4>Category</h4>
                 <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Category</label>
                          <select name="department" class="form-control selectpicker">
                  <option value="">Select your Department/Office</option>
                  <option>Department of Engineering</option>
                  <option>Department of Agriculture</option>
                  <option >Tourism Office</option>
                    </select>
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Sub-Category</label>
                      <select name="department" class="form-control selectpicker">
                  <option value="">Select your Department/Office</option>
                  <option>Department of Engineering</option>
                  <option>Department of Agriculture</option>
                  <option >Tourism Office</option>
                    </select>
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Type</label>
                      <select name="department" class="form-control selectpicker">
                  <option value="">Select your Department/Office</option>
                  <option>Department of Engineering</option>
                  <option>Department of Agriculture</option>
                  <option >Tourism Office</option>
                    </select>
                 </div>
                  <div class="form-group">
                     <i class="fas fa-user"></i>
                    <label class="small mb-1" for="product_id ">Sub-Type</label>
                      <select name="department" class="form-control selectpicker">
                  <option value="">Select your Department/Office</option>
                  <option>Department of Engineering</option>
                  <option>Department of Agriculture</option>
                  <option >Tourism Office</option>
                    </select>
                 </div>
              </div>
              

        </div>
        <div class="row justify-content-center ">
            <button class="btn btn-primary btn-block my-2 mx-2 w-75">Save</button>
        </div>

    </div>
    
</asp:Content>
