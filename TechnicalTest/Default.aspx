<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TechnicalTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome!</h1>
        <p class="lead">This ASP.NET Web application will help us determine your knowledge of C#, HTML, CSS, JavaScript, and SQL.</p>
        <!--<p><a runat="server" href="~/HTML" class="btn btn-primary btn-lg">Get Started &raquo;</a></p>-->
    </div>
    <div class="row">
        <p>
            &emsp;We have setup this project to mirror the web applications that we develop on a day to day basis. This will be a good gauge
            of how your skills and problem solving ability align with our daily routine. Below you will find links to different pages that will 
            test you on individual skills. Each page has a collection of problems for you to try to solve. Many of these problems are directly
            inspired by issues our developers have faced while working on our own software. Some pages may have bugs you need to resolve before you can view the page.
        </p>
        <p>
            Try your best to complete as many of the problems before returning your code to us. Do not be afraid to
            move on and try something else if you get stuck. Good luck!
        </p>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>HTML, CSS, & JavaScript</h2>
            <p>
                This page will test your knowledge of HTML, CSS, and JavaScript. 
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Pages/Html">Get Started &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>C#</h2>
            <p>
                This page will test your knowledge of C#
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Pages/CSharp">Get Started &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>SQL</h2>
            <p>
                This page will test your knowledge of SQL
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Pages/Sql">Get Started &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
