<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TUadmin.aspx.cs" Inherits="ProjectHealth.TUadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>Tuktukan ADMIN</title>
      <link href="css/TUadmin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="nav">
    
        <img src="imagess/City_of_Taguig_Seal.png" class="logo"/>
        <asp:Label ID="Label1" runat="server"  class="logotitle" Text="Taguig City"></asp:Label>


        <asp:Button ID="Dashboard" runat="server" Text="Dashboard" class="button1" OnClick="Dashboard_Click"/><div class="image1"></div>
        <asp:Button ID="Checkup" runat="server" Text="Checkup" class="button2" OnClick="Checkup_Click"/><div class="image2"></div>
        <asp:Button ID="Prenatal" runat="server" Text="Prenatal" class="button3" OnClick="Prenatal_Click"/><div class="image3"></div>
        <asp:Button ID="Staff" runat="server" Text="Staff" class="button5" OnClick="Staff_Click"/><div class="image5"></div>
        <asp:Button ID="Account" runat="server" Text="Account" class="button6" OnClick="Account_Click"/><div class="image6"></div>
       
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Logout" class="button8"/><div class="image8"></div>

    </div>

         <!----------------------------------------------->
         <div class="content">

               <asp:Label ID="Label7" runat="server" class="content title1" Text="Brgy.Tuktukan"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="tagline1" Text="Dashboard"></asp:Label>

              <!----------------------------------------------->
       
             <div class="boxcheckup"> 
                 <asp:Label ID="lblname1" class="lblname1" runat="server" Text="Checkup"></asp:Label>
                 <asp:Label ID="lblcheckup" class="lblcheckup" runat="server" Text="0"></asp:Label>
                 <asp:Label ID="lblname2" class="lblname2" runat="server" Text="Records"></asp:Label>
               
             </div>

               <!----------------------------------------------->
       
             <div class="boxprenatal"> 
                 <asp:Label ID="Label2" class="lblname11" runat="server" Text="Prenatal"></asp:Label>
                 <asp:Label ID="lblprenatal" class="lblprenatal" runat="server" Text="0"></asp:Label>
                 <asp:Label ID="Label4" class="lblname22" runat="server" Text="Records"></asp:Label>
               
             </div>

             

              <!----------------------------------------------->
       
             <div class="boxstaff"> 
                 <asp:Label ID="Label9" class="lblname1111" runat="server" Text="Staff"></asp:Label>
                 <asp:Label ID="lblstaff" class="lblstaff" runat="server" Text="0"></asp:Label>
                 <asp:Label ID="Label11" class="lblname2222" runat="server" Text="Peoples"></asp:Label>
               
             </div>

                <!----------------------------------------------->
       
             <div class="boxgender"> 
                 <asp:Label ID="Label5" class="lblname11111" runat="server" Text="Gender"></asp:Label>
                 <asp:Label ID="lblmale" class="lblmale" runat="server" Text="0"></asp:Label>
                 <asp:Label ID="Label12" class="lblname22222" runat="server" Text="Male"></asp:Label>

                  <asp:Label ID="lblfemale" class="lblfemale" runat="server" Text="0"></asp:Label>
                 <asp:Label ID="Label13" class="lblname222222" runat="server" Text="Female"></asp:Label>


               
             </div>

        </div>




    </form>
</body>
</html>
