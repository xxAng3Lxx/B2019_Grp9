
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="ProjectHealth.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Health Center</title>
      <link href="css/homepage.css" rel="stylesheet" />
    
</head>
    
<body>
    <form id="form1" runat="server">
       <asp:Label ID="Label1" runat="server" class="p0" Text="Which barangay health center would you like to appoint ?"></asp:Label>

    <div class="box1">
        <asp:Label ID="Label2" runat="server" class="box1 p" Text="Barangay :"></asp:Label>
    </div>
    <div class="box2">
   
        <asp:Label ID="Label3" runat="server"  class="box2 p2" Text="Welcome to Taguig Health Center System"></asp:Label>
        <asp:Label ID="Label4" runat="server" class="box2 p3" Text="This Health Center Appointment System focuses and caters the medical needs of all the residents of Taguig City from different Barangays. Exceptional care without an exception."></asp:Label>
        
         </div>

       





        <asp:DropDownList ID="DropDownList1" runat="server" Class="dropdown1">
            <asp:ListItem>Sta Ana</asp:ListItem>
            <asp:ListItem>Tuktukan</asp:ListItem>
            <asp:ListItem>Hagonoy</asp:ListItem>
            <asp:ListItem>Wawa</asp:ListItem>
            <asp:ListItem>Bagumbayan</asp:ListItem>
            <asp:ListItem>Ususan</asp:ListItem>
            <asp:ListItem>North Signal</asp:ListItem>
            <asp:ListItem>Lower Bicutan</asp:ListItem>
            <asp:ListItem>Upper Bicutan</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Go" Class="button1" OnClick="Button1_Click" />
    
        <asp:ImageButton ID="admin" runat="server" ImageUrl="~/imagess/admin.png" class="admin" OnClick="admin_Click" />
    
    </form>
    
</body>
</html>
