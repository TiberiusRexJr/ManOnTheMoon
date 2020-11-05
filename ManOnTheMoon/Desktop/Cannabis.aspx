<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cannabis.aspx.cs" Inherits="ManOnTheMoon.Desktop.Cannabis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid" id="DivMaster">
        <h2 class="text-center mt-3" ><i class="fas fa-cannabis    "></i>Cannabis</h2>
    <div class="container-fluid" id="NavBreadCrumb">
        <div class="float-left">
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                  <li class="breadcrumb-item"><a href="#">Home</a></li>
                  <li class="breadcrumb-item active">Library</li>
                </ol>
              </nav>
        </div>
        <div class="float-right">
            
            <!-- Small button group -->
            <div class="btn-group">
                <button class="btn btn-danger btn-sm dropdown-toggle" type="button" data-toggle="dropdown"
                aria-haspopup="true" aria-expanded="false">
                Small button
                </button>
                <div class="dropdown-menu">
                <a class="dropdown-item" href="#">Action</a>
                <a class="dropdown-item" href="#">Another action</a>
                <a class="dropdown-item" href="#">Something else here</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="#">Separated link</a>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
