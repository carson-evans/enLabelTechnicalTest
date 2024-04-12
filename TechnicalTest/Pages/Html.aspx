<%@ Page Title="HTML, CSS, & JavaScript" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Html.aspx.cs" Inherits="TechnicalTest.HTML" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript"></script>
    <div class="jumbotron">
        <h1>HTML, CSS, & JavaScript</h1>
        <p class="lead">This page will test your knowledge of HTML, CSS, & JavaScript.</p>
        <p class="lead">Navigate to the Html.aspx in the Pages directory within this project to begin</p>
    </div>
    <div>
        <h1>HTML</h1>
        <h2>Part 1 - Image</h2>
        <p class="lead">
            &emsp;Insert an image below this text. An image of enLabel's logo can be found in the Images directory within this project
        </p>
        <h2>Part 2 - Link</h2>
        <p class="lead">
            &emsp;Insert a link to enLabel's website (http://www.enlabel.com) below this text. 
        </p>
        <h2>Part 3 - Navigation Bar</h2>
        <p class="lead">
            &emsp;Currently the navigation bar only provides buttons to return home and go to the C# test and SQL test pages,
            but does not include a way to get to this page. Note that this navigation bar appears on all pages throughout this website.
            Make sure your change is also reflected on all of the other pages.
        </p>
        <h2>Part 4 - Calling C#</h2>
        <p class="lead">
            &emsp;Modify the button below to call the "btnCSharp_Click" function that is within the Html.aspx.cs file when it is clicked
        </p>
        <asp:Button ID="buttonCSharp" runat="server" Text="Call C#" />
    </div>
    <div>
        <h1>CSS</h1>
        <h2>Part 1 - Add CSS Style Sheet</h2>
        <p class="lead">
            &emsp;Add the Button.css style sheet to this page. This style sheet can be found within the CSS directory within this project
        </p>
        <h2>Part 2 - </h2>
        <p class="lead">
            &emsp;Add "btn btn-primary btn-lg" as a css class to the button below. You should notice a style change to this button.
        </p>
        <asp:Button ID="buttonCssPart2" Text="Test" runat="server"/>  
    </div>
    <div>
        <h1>JavaScript</h1>
        <h2>Part 1 - Button Click</h2>
        <p class="lead">
            &emsp;Make the button below display an alert message when clicked
        </p>
        <asp:Button ID="button1" runat="server" Text="Alert"/>
        <h2>Part 2 - Text Change</h2>
        <p class="lead">
            &emsp;Write a javascript function that changes the text of the label. Then modify the below button to call this function when the it is clicked.
        </p>
        <asp:Label ID="lblChangeMe" runat="server">Change Me!
        <asp:Button ID="button2" runat="server" Text="Change Label"/>
    </div>
</asp:Content>
