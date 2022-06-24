<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProjectHealth.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Tuktukan Health Center</title>
      <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="loginn">

        <asp:Label ID="Label4" runat="server" Text="AHHAHHAAHHA"></asp:Label>


        <asp:DropDownList ID="txtuser" runat="server" class="txtuser">
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Staana</asp:ListItem>
            <asp:ListItem>Tuktukan</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtpass" runat="server" type="password" class="txtpass">Password</asp:TextBox>
        <asp:DropDownList ID="txtusertype" runat="server" class="txtusertype">
            <asp:ListItem>Admin Brgy</asp:ListItem>
            <asp:ListItem>Cityhall</asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="btnlogin" runat="server" Text="Login" class="btnlogin" OnClick="btnlogin_Click" />

    
    </div>
        <img src="imagess/mapa.png" class="map" />
       

        <asp:Label ID="Label1" runat="server" class="title1" Text="Taguig Health Center"></asp:Label>
        <asp:Label ID="Label2" runat="server" class="title2" Text="This health facility system serves all of Taguig's barangays"></asp:Label>

        <asp:Label ID="Label3" runat="server" class="title3" Text="Barangay Admin and Cityhall Admin Login Form"></asp:Label>

        <asp:ImageButton ID="back" runat="server" ImageUrl="~/imagess/back.png" CssClass="back" OnClick="back_Click" />


    </form>
</body>
</html>
