<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionStorage.aspx.cs" Inherits="MatrixProject.SessionStorage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        a{display:block;}
    </style>
</head>
<body>
    <div runat="server" id="details" visible="false">
        <h2 runat="server">My bookMarks:</h2>
        <form id="form1" runat="server">
            <div>
            </div>
        </form>
        <asp:HyperLink runat="server" ForeColor="Red" NavigateUrl="~/">Go back</asp:HyperLink>
    </div>
   
</body>
</html>
