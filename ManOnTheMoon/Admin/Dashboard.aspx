<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ManOnTheMoon.Admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="flex" style="background-color:purple; width:100%;" id="DivMaster">
        
        <div class="d-flex" style="display:inline-block; background-color:red; width:30%;" id="DivSidePanel">
            a
        </div>
        <div class="d-flex" style="display:inline-block; flex:1; background-color:blue; width:70%;" id="DivMainContent">
            n
        </div>

    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
