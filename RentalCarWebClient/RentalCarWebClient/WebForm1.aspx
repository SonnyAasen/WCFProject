<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs"
Inherits="RentalCarWebClient.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title></title>
</head>
<body>
 <form id="form1" runat="server">
 <table style="font-family:Arial">
 <tr>
 <td>
     <asp:Label ID="Label1" runat="server" Text="RegNr"></asp:Label>
 </td>
 </tr>
 <tr>
 <td>
 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
 <asp:Button ID="Button1" runat="server" Text="Remove Car"
OnClick="Button1_Click" />
 </td>
 </tr>
     <tr>
         <td>&nbsp;</td>
     </tr>
 </table>
     <p>
         <asp:Label ID="Label2" runat="server" Text="Add New Car"></asp:Label>
     </p>
     <p>
         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         ID</p>
     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
     Brand<p>
         <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
         Model</p>
     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
     Year<p>
         <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
         RegNr</p>
     <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Car" Width="166px" />
     <br />
     <br />
     Add new Customer<p>
         <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
         ID</p>
     <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
     FirstName<p>
         <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
         LastName</p>
     <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
     Telephone<p>
         <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
         Email</p>
     <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Add Customer" Width="166px" />
 </form>
 </body>
 </html>