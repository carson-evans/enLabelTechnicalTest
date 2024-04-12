<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sql.aspx.cs" Inherits="TechnicalTest.Pages.Sql" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="Stylesheet" href="~/CSS/GridView.css" type="text/css" />
    <div class="jumbotron">
        <h1>SQL</h1>
        <p class="lead">This page will test your knowledge of Sql</p>
        <p class="lead">Navigate to the Sql.aspx.cs in the Pages directory within this project to begin. Each function that is used within this page is called within the Page_Load function. Make sure to uncomment these functions to work on them</p>
    </div>
    <div class="row">
        <h1>SQL</h1>
        <h2>Part 1 - Insert Users</h2>
        <p class="lead">
            &emsp; Modify the InsertUsers function to insert Users into the database
        </p>
        <h2>Part 2 - Show active Users only</h2>
        <p class="lead">
            &emsp;The GridView below is meant to display all active users from the Users table in the enLabel Database. 
            Write a SQL statement within the DisplayActiveUsers function to retrieve all active users. Use "enLabelDatabase.dbo.[User]" for the table name and "Activated
        </p>
        <asp:GridView ID="gridView" runat="server"
            CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">

        </asp:GridView>

        <h2>Part 3 - Debugging</h2>
        <p class="lead">
            &emsp;Resolve any issues with this SqlBug function
        </p>
    </div>
</asp:Content>
