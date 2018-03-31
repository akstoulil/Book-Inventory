﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Remove.aspx.cs" Inherits="FinalProject.Remove" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Inventory - Remove Inventory</title>
    <meta name="description" content="Group Project, Remove Inventory" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/main.css" rel="stylesheet" /> 
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="col-md-12">
            <h1>
                <asp:Label ID="lblRemove" runat="server" Text="Remove Inventory:"></asp:Label>
            </h1>
        </div>
        <div class="form-group">
                <div class="col-md-12 col-sm-12 col-xs-12">
                    <asp:DropDownList ID="dropDownEditSearch" runat="server" CssClass="form-control" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Title" DataValueField="Isbn" OnSelectedIndexChanged="dropDownEditSearch_SelectedIndexChanged" Width="300px">
                        <asp:ListItem Value="ISBN"></asp:ListItem>
                        <asp:ListItem Value="Title"></asp:ListItem>    
                        <asp:ListItem Value="Author's Last Name"></asp:ListItem>    
                    </asp:DropDownList>                                    
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IsbnTitleString %>" SelectCommand="SELECT [Isbn], [Title] FROM [Table]"></asp:SqlDataSource>
                    <h3 style="font-weight: bold; width: 100%;">Please Enter Your Values Below:</h3>
                </div>                
        </div>
        <br />  
        <br />
        <div class="col-md-12">
            <b><asp:Label ID="lblTitleLabel" runat="server" Text="Title: "></asp:Label></b>
            <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
        </div> 
        <br /> 
        <div class="col-md-12">
            <b><asp:Label ID="lblFirstNameLabel" runat="server" Text="First Name: "></asp:Label></b>
            <asp:Label ID="lblFirstName" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div class="col-md-12">
            <b><asp:Label ID="lblLastNameLabel" runat="server" Text="Last Name: "></asp:Label></b>
            <asp:Label ID="lblLastName" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div class="col-md-12">
            <b><asp:Label ID="lblCategoriesLabel" runat="server" Text="Categories: "></asp:Label></b>
            <asp:Label ID="lblCategories" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div class="col-md-12">
            <b><asp:Label ID="lblRatingLabel" runat="server" Text="Rating: "></asp:Label></b>
            <asp:Label ID="lblRating" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div class="col-md-12">
            <asp:Button ID="btnDelete" runat="server" Text="Delete Inventory" CssClass="btn btn-primary" OnClick="btnDelete_Click" />
        </div>
    </div>
    </form>
</body>
</html>
