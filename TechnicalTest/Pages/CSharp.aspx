<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CSharp.aspx.cs" Inherits="TechnicalTest.Pages.CSharp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>C#</h1>
        <p class="lead">This page will test your knowledge of C#</p>
        <p class="lead">Navigate to the CSharp.aspx.cs in the Pages directory within this project to begin</p>
    </div>
    <div>
        <h1>C#</h1>
        <h2>Part 1 - Modifying Page Elements</h2>
        <p class="lead">
            &emsp;Change the text of the below label using C# within the Page_Load function within the CSharp.aspx.cs
        </p>
        <asp:Label ID="lblCSharpPart1" runat="server">Change me!</asp:Label>
        <h2>Part 2 - Casting</h2>
        <p class="lead">
            &emsp;Sometimes boolean values are stored as strings within our system. However this data is not always standardized which can make these strings
            difficult to deal with i.e. both "0" and "false" evaluate to false when cast to a boolean. It can be helpful to have a function that can 
            convert string values into booleans regardless of their format.
        </p>
        <p class="lead">
            Edit the GetTrueCount function within the CSharp.aspx.cs so that it returns the count of strings in an array that will evaluate as "true" when cast to a boolean variable.
        </p>
        <h2>Part 3 - String Compression</h2>
        <p class="lead">
            &emsp;Write a function that takes a string and returns a compressed version of that string by 
             replacing repeated characters with that character and then a count of repeated characters. 
             For instance the string "aaaabbccccdddeeeef" should return "a4b2c4d3e4f1". 
        </p>
        <p class="lead">
            &emsp;Write your code within the CSharp.aspx.cs. A place to call your function is provided in the Page_Load function
        </p>
        <h2>Part 4 - Comparison Bug</h2>
        <p class="lead">
            &emsp;Explain why the ClearList1 and ClearList2 functions cause different behavior. Your explanation can be placed in the Page_Load function within the CSharp.aspx.cs
        </p>
    </div>
</asp:Content>
