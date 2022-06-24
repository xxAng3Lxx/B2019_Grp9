<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staana.aspx.cs" Inherits="ProjectHealth.staana" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>STA ANA Health Center</title>
      <link href="css/staana.css" rel="stylesheet" />
      <style type="text/css">
          .auto-style1 {
              width: 900px;
              height: 1040px;
          }
      </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="nav">

        <!----<p class="nav title"> STA ANA</p> ---->
        <asp:Button ID="Button1" runat="server" Text="StaAna" Class="navhome" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Checkup" Class="navcheckup" OnClick="Button2_Click"/>
        <asp:Button ID="Button3" runat="server" Text="Prenatal" Class="navprenatal" OnClick="Button3_Click"/>
    
        <asp:Button ID="Button4" runat="server" Class="hoome" OnClick="Button4_Click" Text="Health Center"  />

    </div>

    <div class="staana">
        
         <asp:Label ID="Label1" runat="server" class="staana p1" Text="Brgy Sta Ana Health Center"></asp:Label>
        <asp:Label ID="Label2" runat="server" class="staana p11" Text="All residents of the community can receive first aid, mother and child health care, social disease diagnostics, and other basic health services at the Barangay Health Center."></asp:Label>

    </div>
    </form>
    
        <img class="nurse" src="imagess/nurse.png"  />

   
</body>
</html>
