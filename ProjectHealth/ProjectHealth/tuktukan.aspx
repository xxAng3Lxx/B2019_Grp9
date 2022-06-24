<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuktukan.aspx.cs" Inherits="ProjectHealth.tuktukan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Tuktukan Health Center</title>
      <link href="css/tuktukan.css" rel="stylesheet" />
      
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="nav">

        <!---- hoome  navhome  navcheckup  navprenatal  ---->
        <asp:Button ID="home" runat="server" Text="Health Center"  Class="hoome" OnClick="home_Click" />
        <asp:Button ID="tuk" runat="server" Text="Tuktukan" Class="navhome" OnClick="tuk_Click" />
        <asp:Button ID="check" runat="server" Text="Checkup" Class="navcheckup" OnClick="check_Click" />
        <asp:Button ID="pre" runat="server" Text="Prenatal" Class="navprenatal" OnClick="pre_Click" />


    </div>
             
        
        
        
    <div class="tuktukan">
      
        <asp:Label ID="Label1" runat="server" class="tuktukan p1" Text="Brgy Tuktukan Health Center"></asp:Label>
        <asp:Label ID="Label2" runat="server" class="tuktukan p11" Text="All residents of the community can receive first aid, mother and child health care, social disease diagnostics, and other basic health services at the Barangay Health Center."></asp:Label>


    </div>
        <img class="nurse" src="imagess/tuktukan.png" />

    </form>
</body>
</html>
