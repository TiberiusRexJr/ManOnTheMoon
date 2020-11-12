<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Add_Product.aspx.cs" Inherits="ManOnTheMoon.Admin.Add_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Content/Drag&Drop.css" />
    
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
            <!--Image_Upload_1-->
            <form>
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                      <div class="form-group">
                        <label class="control-label">Upload File</label>
                        <div class="preview-zone hidden">
                          <div class="box box-solid">
                            <div class="box-header with-border">
                              <div><b>Image </b></div>
                              <div class="box-tools pull-right">
                                <button type="button" class="btn btn-danger btn-xs remove-preview">
                                 <i class="fas fa-sync-alt"></i> Reset 
                                </button>
                              </div>
                            </div>
                            <div class="box-body"></div>
                          </div>
                        </div>
                        <div class="dropzone-wrapper">
                          <div class="dropzone-desc">
                            <i class="fas fa-sync-alt"></i>
                            <p>Choose an image file or drag it here.</p>
                          </div>
                          <input type="file" name="img_logo" class="dropzone">
                        </div>
                      </div>
                </div>
             </div>
            </form>
            <!--Image_Upload_1--End-->
          <!--Image_Upload_2-->
            <form>
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                      <div class="form-group">
                        <div class="preview-zone hidden">
                          <div class="box box-solid">
                            <div class="box-header with-border">
                              <div><b>Alternative Image 1</b></div>
                              <div class="box-tools pull-right">
                                <button type="button" class="btn btn-danger btn-xs remove-preview">
                                 <i class="fas fa-sync-alt"></i> Reset 
                                </button>
                              </div>
                            </div>
                            <div class="box-body"></div>
                          </div>
                        </div>
                        <div class="dropzone-wrapper">
                          <div class="dropzone-desc">
                            <i class="fas fa-sync-alt"></i>
                            <p>Choose an image file or drag it here.</p>
                          </div>
                          <input type="file" name="img_logo" class="dropzone">
                        </div>
                      </div>
                </div>
             </div>
            </form>
            <!--Image_Upload_2--End-->
             <!--Image_Upload_3-->
            <form>
                <div class="row">
                    <div class="col-lg-12 col-md-12">
                      <div class="form-group">
                       
                        <div class="preview-zone hidden">
                          <div class="box box-solid">
                            <div class="box-header with-border">
                              <div><b>Alternative Image 2</b></div>
                              <div class="box-tools pull-right">
                                <button type="button" class="btn btn-danger btn-xs remove-preview">
                                 <i class="fas fa-sync-alt"></i> Reset 
                                </button>
                              </div>
                            </div>
                            <div class="box-body"></div>
                          </div>
                        </div>
                        <div class="dropzone-wrapper">
                          <div class="dropzone-desc">
                            <i class="fas fa-sync-alt"></i>
                            <p>Choose an image file or drag it here.</p>
                          </div>
                          <input type="file" name="img_logo" class="dropzone">
                        </div>
                      </div>
                </div>
             </div>
            </form>
            <!--Image_Upload_3--End-->
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
