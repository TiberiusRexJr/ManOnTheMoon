<%@ Page Title="" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="Cannabis.aspx.cs" Inherits="ManOnTheMoon.Desktop.Cannabis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid mx-5 mx-auto" id="DivMaster" style="width:85%;">
        <h2 class="text-center mt-3" ><i class="fas fa-cannabis    "></i>Cannabis</h2>
    <div class="container-fluid mb-3" id="NavBreadCrumb">
        <div class="float-left">
          <div class="d-flex">
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                  <li class="breadcrumb-item"><a href="#">Home</a></li>
                  <li class="breadcrumb-item active">Library</li>
                </ol>
              </nav>
          </div>
        </div>
        <div class="float-right">
            
            <div class="dropdown">
  <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
    Dropdown button
  </button>
  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
    <a class="dropdown-item" href="#">Sort By Popularity</a>
    <a class="dropdown-item" href="#">Sort by latest</a>
      <a class="dropdown-item" href="#">Sort by Price: Low to High</a>
      <a class="dropdown-item" href="#">Sort by Price: High to Low</a>

  </div>
</div>
        </div>
    </div>
        <div class="flex" style="margin-top:5%; " id="DivSearch">
            
         <div style="margin-top:1%; width:20%; margin-left:0%; display:inline-block;">
            <div class="d-flex" style="">
                <i class="fas fa-search" aria-hidden="true"></i>
                
                <input class="form-control form-control-sm active-purple ml-1 w-75" type="text" placeholder="Search"
                aria-label="Search">
              </div>  
         </div>
            <div class="float-right ml-5" style="margin-top:1%; margin-right:10%; flex:1; width:50%; display:inline-block; ">
               <div class="d-inline-flex flex-row">
                <p class="text-xl text-justify">
                  Top shelf selections on medicinal marijuana flower’s of all types including moonrock’s, indica’s, sativa’s and hybrid’s. Herb Approach offers the largest selection of cannabis strains allowing you to buy weed online easy!
                </p>
                </div>
         </div>
        </div>
        <div class="container-fluid my-2" id="DivMainContent">
            <div class="container float-left" id="DivMainContentLeft" style="display:inline-block;  width:20%;">
                <!--Shop Page Start-->

               <h5 class="h5-responsive">Shop Page</h5>
                <hr style="width:5%; margin-left:0px;"/>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" id="defaultGroupExample1" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample1">Default</label>
                </div>

                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" id="defaultGroupExample2" name="groupOfDefaultRadios" >
                  <label class="custom-control-label" for="defaultGroupExample2">Price:high to low</label>
                </div>

                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" id="defaultGroupExample3" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample3">Price: low to high</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" id="defaultGroupExample4" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample4">Product Name</label>
                </div>
                <!--Shop Page End-->
                <!--price start-->
                               <h5 class="h5-responsive my-3">Price</h5>
                <hr style="width:5%; margin-left:0px;"/>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="0-30" id="defaultGroupExample5" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample5">0-30</label>
                </div>

                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="30-80" id="defaultGroupExample6" name="groupOfDefaultRadios" >
                  <label class="custom-control-label" for="defaultGroupExample6">30-80</label>
                </div>

                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="80-130" id="defaultGroupExample7" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample7">80-130</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="130-180" id="defaultGroupExample8" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample4">130-180</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="180-230" id="defaultGroupExample9" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample4">180-230</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="230-" id="defaultGroupExample10" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample4">230+</label>
                </div>

                <!--Price End-->
                <!--Categories start-->
                               <h5 class="h5-responsive my-3">Categories</h5>
                <hr style="width:5%; margin-left:0px;"/>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="Hybrid" id="defaultGroupExample11" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample11">Hybrid</label>
                </div>

                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="Sativa" id="defaultGroupExample12" name="groupOfDefaultRadios" >
                  <label class="custom-control-label" for="defaultGroupExample12">Sativa</label>
                </div>

                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="Indica" id="defaultGroupExample13" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample13">Indica</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="Vendors" id="defaultGroupExample14" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample14">Vendors</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="Edibles" id="defaultGroupExample15" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample15">180-230</label>
                </div>
                <div class="custom-control custom-radio">
                  <input type="radio" class="custom-control-input" value="Flash Sale" id="defaultGroupExample16" name="groupOfDefaultRadios">
                  <label class="custom-control-label" for="defaultGroupExample16">Flash Sale</label>
                </div>

                <!--Categories End-->
            </div>
            <!--MainContentDivRight_Start-->
            <div class="container float-right" style="width:80%; display:inline-block;" id="DivMainContentRight">
               <div class="row">
                   <div class="col-lg mx-1 my-1">
                                             <!--Card Narrower-->
                        <div class="card card-cascade narrower">

                          <!--Zoom effect-->
                            <div class="view overlay zoom">
                              <img src="https://mdbootstrap.com/img/Photos/Horizontal/Nature/6-col/img%20(131).jpg" class="img-fluid " alt="zoom">
                              <div class="mask flex-center waves-effect waves-light">
                                <p class="white-text">Zoom effect</p>
                              </div>
                            </div>
                          <!--/.Card image-->

                          <!--Card content-->
                          <div class="card-body card-body-cascade">
                            <h5 class="purple-text text-center"><i class="fas fa-bed"></i> Indica</h5>
                            <!--Title-->
                            <h4 class="card-title">Cheat day inspirations</h4>
                            <!--Text-->
                            <p class="card-text">Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit
                              laboriosam, nisi ut aliquid ex ea commodi.</p>
                            <a class="btn btn-unique">Button</a>
                          </div>
                          <!--/.Card content-->

                        </div>
                        <!--/.Card Narrower-->

                   </div>
                     <div class="col-lg mx-1 my-1">
                                             <!--Card Narrower-->
                        <div class="card card-cascade narrower">

                          <!--Card image-->
                          <div class="view view-cascade overlay">
                            <img src="https://mdbootstrap.com/img/Photos/Lightbox/Thumbnail/img%20(147).jpg" class="card-img-top"
                              alt="narrower">
                            <a>
                              <div class="mask rgba-white-slight"></div>
                            </a>
                          </div>
                          <!--/.Card image-->

                          <!--Card content-->
                          <div class="card-body card-body-cascade">
                            <h5 class="yellow-text"><i class="far fa-surprise"></i>Sativa</h5>
                            <!--Title-->
                            <h4 class="card-title">Cheat day inspirations</h4>
                            <!--Text-->
                            <p class="card-text">Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit
                              laboriosam, nisi ut aliquid ex ea commodi.</p>
                            <a class="btn btn-unique">Button</a>
                          </div>
                          <!--/.Card content-->

                        </div>
                        <!--/.Card Narrower-->

                   </div>
                     <div class="col-lg mx-1 my-1">
                                             <!--Card Narrower-->
                        <div class="card card-cascade narrower">

                          <!--Card image-->
                          <div class="view view-cascade overlay">
                            <img src="https://mdbootstrap.com/img/Photos/Lightbox/Thumbnail/img%20(147).jpg" class="card-img-top"
                              alt="narrower">
                            <a>
                              <div class="mask rgba-white-slight"></div>
                            </a>
                          </div>
                          <!--/.Card image-->

                          <!--Card content-->
                          <div class="card-body card-body-cascade">
                            <h5 class="green-text"><i class="fab fa-reddit-alien"></i>Hybrid</h5>
                            <!--Title-->
                            <h4 class="card-title">Cheat day inspirations</h4>
                            <!--Text-->
                            <p class="card-text">Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit
                              laboriosam, nisi ut aliquid ex ea commodi.</p>
                            <a class="btn btn-unique">Button</a>
                          </div>
                          <!--/.Card content-->

                        </div>
                        <!--/.Card Narrower-->

                   </div>
                     <div class="col-lg mx-1 my-1">
                                             <!--Card Narrower-->
                        <div class="card card-cascade narrower">

                          <!--Card image-->
                          <div class="view view-cascade overlay">
                            <img src="https://mdbootstrap.com/img/Photos/Lightbox/Thumbnail/img%20(147).jpg" class="card-img-top"
                              alt="narrower">
                            <a>
                              <div class="mask rgba-white-slight"></div>
                            </a>
                          </div>
                          <!--/.Card image-->

                          <!--Card content-->
                          <div class="card-body card-body-cascade">
                            <h5 class="pink-text"><i class="fas fa-utensils"></i> Culinary</h5>
                            <!--Title-->
                            <h4 class="card-title">Cheat day inspirations</h4>
                            <!--Text-->
                            <p class="card-text">Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit
                              laboriosam, nisi ut aliquid ex ea commodi.</p>
                            <a class="btn btn-unique">Button</a>
                          </div>
                          <!--/.Card content-->

                        </div>
                        <!--/.Card Narrower-->

                   </div>
               </div>
                <div class="row">
                    <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
               </div>
                <div class="row">
                    <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
               </div>
                <div class="row">
                    <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
                   <div class="col-lg mx-1 my-1">

                   </div>
               </div>

            </div>
            <!--MainContentDivRight_End-->

        </div>
    </div>
</asp:Content>
