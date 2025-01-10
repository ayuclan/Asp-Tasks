<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="t1_prg4.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
    <title></title>
    <style>
        table {
            border-collapse: collapse;
            width: 50%;
            margin: auto;
            border: 4px double black; /* Double border for the table */
        }
        th, td {
            border: 2px double black; /* Double border for table cells */
            text-align: center;
            padding: 8px;
        }
        th {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>
    <h2 style="text-align:center;"></h2>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
    </form>
</body>
</html>
