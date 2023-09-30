<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Header.aspx.cs" Inherits="WebApplication10.Header" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Yanone+Kaffeesatz&display=swap" rel="stylesheet">
    <title></title>
    <style>
        *{
            margin:0px;
            padding:0px;
        }

        .header{
            background-color:black;
            width:100%;
            height:50px;
        }
        .logo{
            left:20px;
            top:10px;
            position:relative;
            font-family: 'Yanone Kaffeesatz', sans-serif;
            text-decoration:none;
            font-size:18pt;
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <a href="https://www.google.com/" class="logo">Header</a>
        </div>
    </form>
</body>
</html>
