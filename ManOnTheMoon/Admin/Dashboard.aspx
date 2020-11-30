<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ManOnTheMoon.Admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
       <a class="navbar-brand" href="#">Start Bootstrap</a>
        <button class="btn btn-link btn-sm order-1 order-lg-0" id="sidebarToggle" href="#"><i class="fas fa-bars"></i></button>
       <form class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
                <div class="input-group">
                    <input class="form-control" type="text" placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2" />
                    <div class="input-group-append">
                        <button class="btn btn-primary" type="button"><i class="fas fa-search"></i></button>
                    </div>
                </div>
            </form>
        <!-- Navbar-->
            <ul class="navbar-nav ml-auto ml-md-0">
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="userDropdown" href="#" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"><i class="fas fa-user fa-fw"></i></a>
                    <div class="dropdown-menu dropdown-menu-right" aria-labelledby="userDropdown">
                        <a class="dropdown-item" href="#">Settings</a>
                        <a class="dropdown-item" href="#">Activity Log</a>
                        <div class="dropdown-divider"></div>
                        <a class="dropdown-item" href="login.html">Logout</a>
                    </div>
                </li>
            </ul>
   </nav>
    <div id="layoutSidenav">
            <div id="layoutSidenav_nav">
                <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                    <div class="sb-sidenav-menu">
                        <div class="nav">
                            <div class="sb-sidenav-menu-heading">Core</div>
                            <a class="nav-link" href="index.html">
                                <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                                Dashboard
                            </a>
                            <div class="sb-sidenav-menu-heading">Interface</div>
                            <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseLayouts" aria-expanded="false" aria-controls="collapseLayouts">
                                <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                                Layouts
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                            </a>
                            <div class="collapse" id="collapseLayouts" aria-labelledby="headingOne" data-parent="#sidenavAccordion">
                                <nav class="sb-sidenav-menu-nested nav">
                                    <a class="nav-link" href="layout-static.html">Static Navigation</a>
                                    <a class="nav-link" href="layout-sidenav-light.html">Light Sidenav</a>
                                </nav>
                            </div>
                            <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapsePages" aria-expanded="false" aria-controls="collapsePages">
                                <div class="sb-nav-link-icon"><i class="fas fa-book-open"></i></div>
                                Pages
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                            </a>
                            <div class="collapse" id="collapsePages" aria-labelledby="headingTwo" data-parent="#sidenavAccordion">
                                <nav class="sb-sidenav-menu-nested nav accordion" id="sidenavAccordionPages">
                                    <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#pagesCollapseAuth" aria-expanded="false" aria-controls="pagesCollapseAuth">
                                        Authentication
                                        <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                                    </a>
                                    <div class="collapse" id="pagesCollapseAuth" aria-labelledby="headingOne" data-parent="#sidenavAccordionPages">
                                        <nav class="sb-sidenav-menu-nested nav">
                                            <a class="nav-link" href="login.html">Login</a>
                                            <a class="nav-link" href="register.html">Register</a>
                                            <a class="nav-link" href="password.html">Forgot Password</a>
                                        </nav>
                                    </div>
                                    <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#pagesCollapseError" aria-expanded="false" aria-controls="pagesCollapseError">
                                        Error
                                        <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                                    </a>
                                    <div class="collapse" id="pagesCollapseError" aria-labelledby="headingOne" data-parent="#sidenavAccordionPages">
                                        <nav class="sb-sidenav-menu-nested nav">
                                            <a class="nav-link" href="401.html">401 Page</a>
                                            <a class="nav-link" href="404.html">404 Page</a>
                                            <a class="nav-link" href="500.html">500 Page</a>
                                        </nav>
                                    </div>
                                </nav>
                            </div>
                            <div class="sb-sidenav-menu-heading">Addons</div>
                            <a class="nav-link" href="charts.html">
                                <div class="sb-nav-link-icon"><i class="fas fa-chart-area"></i></div>
                                Charts
                            </a>
                            <a class="nav-link" href="tables.html">
                                <div class="sb-nav-link-icon"><i class="fas fa-table"></i></div>
                                Tables
                            </a>
                        </div>
                    </div>
                    <div class="sb-sidenav-footer">
                        <div class="small">Logged in as:</div>
                        Start Bootstrap
                    </div>
                </nav>
            </div>
            <div id="layoutSidenav_content">
                <main>
                    <div class="container-fluid">
                        <h1 class="mt-4">Charts</h1>
                        <ol class="breadcrumb mb-4">
                            <li class="breadcrumb-item"><a href="index.html">Dashboard</a></li>
                            <li class="breadcrumb-item active">Charts</li>
                        </ol>
                        <div class="card mb-4">
                            <div class="card-body">
                                Chart.js is a third party plugin that is used to generate the charts in this template. The charts below have been customized - for further customization options, please visit the official
                                <a target="_blank" href="https://www.chartjs.org/docs/latest/">Chart.js documentation</a>
                                .
                            </div>
                        </div>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-chart-area mr-1"></i>
                                Area Chart Example
                            </div>
                            <div class="card-body"><canvas id="myAreaChart" width="100%" height="30"></canvas></div>
                            <div class="card-footer small text-muted">Updated yesterday at 11:59 PM</div>
                        </div>
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="card mb-4">
                                    <div class="card-header">
                                        <i class="fas fa-chart-bar mr-1"></i>
                                        Bar Chart Example
                                    </div>
                                    <div class="card-body"><canvas id="myBarChart" width="100%" height="50"></canvas></div>
                                    <div class="card-footer small text-muted">Updated yesterday at 11:59 PM</div>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="card mb-4">
                                    <div class="card-header">
                                        <i class="fas fa-chart-pie mr-1"></i>
                                        Pie Chart Example
                                    </div>
                                    <div class="card-body"><canvas id="myPieChart" width="100%" height="50"></canvas></div>
                                    <div class="card-footer small text-muted">Updated yesterday at 11:59 PM</div>
                                </div>
                            </div>
                        </div>
                        <div class="card mb-4">
                            <div class="card-header">
                                <i class="fas fa-chart-bar mr-1"></i>
                                Store Maintenance
                            </div>
                            <div class="card-body">
                                <div class="row">
                            
                            <div class="col-lg-6">
                                <button class="btn btn-primary btn-block" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
                                        <i class="fas fa-chart-bar mr-1"></i>
                                        Add Product
                                      </button>
                                        <div class="collapse" id="collapseExample">
                                      <div class="card card-body">
                                        <form>

                                        </form>
                                      </div>
                                    </div>
                            </div>
                            <div class="col-lg-6">
                                <button class="btn btn-primary btn-block" type="button" data-toggle="collapse" data-target="#collapseExample1" aria-expanded="false" aria-controls="collapseExample1">
                                        <i class="fas fa-chart-bar mr-1"></i>
                                       Add Brand
                                      </button>
                                        <div class="collapse" id="collapseExample1">
                                      <div class="card card-body">
                                        <form id="form_brand_name">
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputBrandName">Brand Name</label>
                                                        <input class="form-control py-4" id="inputBrandName" name="Name" type="text" placeholder="e.g Nike" />
                                                    </div>
                                                </div>
                                                
                                            </div>
                                            <div class="form-group mt-4 mb-0"><a class="btn btn-primary btn-block" onclick="SubmitNewBrand()">Submit</a></div>
                                        </form>
                                      </div>
                                    </div>
                            </div>
                                    <div class="col-lg-6 mt-1">
                                <button class="btn btn-primary btn-block" type="button" data-toggle="collapse" data-target="#collapseExample3" aria-expanded="false" aria-controls="collapseExample1">
                                        <i class="fas fa-chart-bar mr-1"></i>
                                       Add Category
                                      </button>
                                        <div class="collapse" id="collapseExample3">
                                      <div class="card card-body">
                                        <form>
                                            <div class="form-row">
                                                <div class="col-md-6">
                                                    <div class="form-group">
                                                        <label class="small mb-1" for="inputCategoryName">Cateogry Name</label>
                                                        <input class="form-control py-4" id="inputCategoryName" type="text" placeholder="e.g Nike" />
                                                    </div>
                                                </div>
                                                
                                            </div>
                                            <div class="form-group mt-4 mb-0"><button class="btn btn-primary btn-block" type="submit">Submit</button></div>
                                        </form>
                                      </div>
                                    </div>
                            </div>
                        </div>
                            </div>
                        </div>
                        
                    </div>
                </main>
                <footer class="py-4 bg-light mt-auto">
                    <div class="container-fluid">
                        <div class="d-flex align-items-center justify-content-between small">
                            <div class="text-muted">Copyright &copy; Your Website 2020</div>
                            <div>
                                <a href="#">Privacy Policy</a>
                                &middot;
                                <a href="#">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
   
    <div class="modal fade" id="ModalAdminMessenger" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header" id="ModalAdminMessengerHeader">
        <h5 class="modal-title" id="exampleModalLabel">Success</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body" id="ModalAdminMessengerBody">
       
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>

    <script>
import { error } from "jquery";

        
       


        $(document).ready(function ()
        {
        
        })

        //AjaxC.R.U.D
        AjaxPost(data, senderId)
        {
            const CRUD_TYPE = "";
            const API_POST_=" ";

            if (data == null || senderId == null)
            {
                ModalMessenger(null, false, CRUD_TYPE);
            }

            $.ajax({
                type: "POST",
                data: data,
                url: API_POST_,
                success: function (response, jqXHR, data) { },
                statusCode:
                {
                    400: function (response, jqXHR, data) {
                        ModalMessenger(null, false, CRUD_TYPE);
                    },
                    500: function (response, jqXHR, data) {
                        var successStatus = false;
                        ModalMessenger(null, false, CRUD_TYPE);
                    },
                    201: function (response, jqXHR, data) {
                        var successStatus = true;
                        ModalMessenger(data, successStatus, CRUD_TYPE);
                    }
                },
                error: function (response, jqXHR, data)
                {
                    ModalMessenger(data, false, CRUD_TYPE);
                }
            })
        }
        //AjaxC.R.U.D-End

        //ModalMessenger
        function ModalMessenger(data, successStatus, crudType)
        {
            var htmlModalHeaderElement = "";
            var htmlModalBodyElement = "";
            <p class="text-justify"></p>
            if (data == null || successStatus == false)
            {
                $("#").removeClass("");
                $("#").addClass("");
            }
        }
        //ModalMessenger-End
        function SubmitNewBrand()
        {
            var API_POSTBRAND_URL = "https://localhost:44310/api/Admin/PostBrand/brand";
            
            var crudType = "Created";
            var tableType = "Brand";
            var brand = new Object();

            brand.Name = $("#inputBrandName").val();
        }
        function SubmitNewCategory()
        {
            var API_POSTCATEGORY_URL = "https://localhost:44310/api/Admin/PostCategory/category";
            var crudType = "created";
            var tableType = "Category";

            var category = new Object();

            category.Name = $("#inputCategoryName").val();
        }
        function AjaxExistByName(item, tableType)
        {
            const API_EXISTBYNAME_URL = "https://localhost:44310/api/Admin/ExistByName/";

            $.ajax({
                type: "GET",
                url: API_EXISTBYNAME_URL + item + "/" + tableType,
                statusCode:
                {
                    404: function () { },
                    400: function () { },
                    302: function () { }

                },
                success: function (data,textStatus,jqXHR)
                {
                         
                },
                error: function (jqxhr, textStatus, errorThrown)
                {

                }
            })
        }

        function AjaxPost(apiUrl,data,crud_type)
        {
            var status = false;

            if (brand == null || api_url == null)
            {
                //Messenger("Empty Values Please try again", status);
                alert("null");
            }
            else
            {
                
                $.ajax({
                    type: "POST",
                    url: api_url,
                    data: JSON.stringify(brand),
                    contentType:"application/json",
                    success: function (data, textStatus, xhr,responseText,response) {
                        status = true;
                        alert(data.Name + data.Id+ data.ReasonPhrase+ data.status);
                        alert(textStatus);
                        alert(xhr.status);
                        alert(xhr.statusText);
                        alert(textStatus);
                        alert(data.responseText);
                        alert(response.responseText);
                        alert(response.responseJSON);
                        alert(response.textStatus)
                        alert(response.statusText);




                        Messenger(data.Name, crud_type, status);
                    },
                    error: function (jqxhr, textStatus, errorThrown)
                    {
                        status = false;
                        console.log("Fuck:");
                        console.log(errorThrown);
                        console.log(textStatus.toString);
                        Messenger(brand.Name, crud_type, status,errorThrown);

                    }

                }).fail(function(jqxhr,textStatus,errorThrown)
                {
                    alert(jqxhr.status + textStatus + errorThrown.toString); 
                })

               
            }

        }

        function Messenger(message,crud_type,status,errorMessage)
        {
            var htmlHeaderSuccessMessage = ' ';
            var htmlHeaderFailureMessage= ' ';

            var htmlHeaderSuccessClass = ' ';
            var htmlHeaderFailureClass = ' ';

            var htmlBodySuccessClass = ' ';
            var htmlBodyFailureClass = ' ';

            var htmlBodySuccessMessage = ' ';
            var htmlBodyFailureMessage = ' ';




            var html_Success = '<p class="text-justify font-italic">' + message + " " + crud_type + '" "' + '"Successfully"</p>'

            var html_Failure = '<p class="text-justify font-italic">' + message + " " + crud_type + '" "' + '"Unsuccessfully"</p>' +
                '<p class="font-weight-bold">' + errorMessage + '</p>'

            if (status ==true)
            {
                alert("True");
                $("#ModalAdminMessengerHeader").removeClass("bg-danger");
                $("#ModalAdminMessengerHeader").addClass("bg-success");
                $("#ModalAdminMessengerBody").append(html_Success);
                

            }
            else if (status == false)
            {
                alert("false");

                $("#ModalAdminMessengerHeader").removeClass("bg-success");
                $("#ModalAdminMessengerHeader").addClass("bg-danger");
                $("#ModalAdminMessengerBody").append(html_Failure);

            }
            
            $("#ModalAdminMessenger").modal('show');
            $("#ModalAdminMessenger").modal('hide');
            

            
        }



        
    </script>
</asp:Content>

