<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staanaprenatal.aspx.cs" Inherits="ProjectHealth.staanaprenatal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>STA ANA Health Center</title>
      <link href="css/staanaprenatal.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <section class="page1" id="page1">
            


            <div class="nav">


        
                <asp:Button ID="homepage" runat="server" OnClick="homepage_Click" Text="Health Center" Class="hoome"/>
                <asp:Button ID="staana" runat="server" OnClick="staana_Click" Text="StaAna" Class="navhome" />
                <asp:Button ID="checkup" runat="server" OnClick="checkup_Click" Text="Checkup" Class="navcheckup" />
                <asp:Button ID="prenatal" runat="server" OnClick="prenatal_Click" Text="Prenatal" Class="navprenatal" />


        
                </div>

         


         <asp:Label ID="Label1" runat="server"  class="headingss" Text="Prenatal"></asp:Label>
         <asp:Label ID="Label2" runat="server" class="sentence1" Text="Prenatal care is a checkups from a doctor, nurse, or midwife throughout your pregnancy. It helps keep you and your future baby healthy."></asp:Label>
         <asp:Label ID="Label3" runat="server" class="sentence2" Text="prenatal care can help prevent complications and inform women about important steps they	can take to protect their infant and ensure a healthy pregnancy"></asp:Label>




          <a href="#page2" class="btnsection"> Prenatal Reservation</a>

         <img src="imagess/pregnancy-birth-infographics-presentation-template-icon-icons-set-49086256.jpg" class="image2" />

        
        </section>

        <section class="page2" id="page2">
           
          

            <asp:Label ID="Label4" runat="server"  class="title1" Text="Appointment"></asp:Label>
            <asp:Label ID="Label5" runat="server" class="title2" Text="Prenatal Reservation"></asp:Label>

        <div class="cfillup">
         
           
         
             <asp:TextBox ID="txtpname" runat="server" Class="txtpname"></asp:TextBox>
            <asp:TextBox ID="txtpage" runat="server" Class="txtpage"></asp:TextBox>
            <asp:TextBox ID="txtpaddress" runat="server" Class="txtpaddress"></asp:TextBox>
            <asp:TextBox ID="txtpcontact" runat="server" Class="txtpcontact"></asp:TextBox>
            <asp:TextBox ID="txtpdate" runat="server" type="date" Class="txtpdate"></asp:TextBox>

             <asp:Button ID="submit" runat="server" Text="Submit"  Class="buttonsubmit" OnClick="submit_Click" />



                


            <asp:Label ID="Label6" runat="server" class="cfillup FullName" Text="FullName:"></asp:Label>
            <asp:Label ID="Label7" runat="server" class="cfillup Age"      Text="Age:"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="cfillup Address"  Text="Address:"></asp:Label>
            <asp:Label ID="Label9" runat="server" class="cfillup Date"      Text="Date:"></asp:Label>
            <asp:Label ID="Label10" runat="server" class="cfillup Contact" Text="Contact:"></asp:Label>



             <asp:TextBox ID="txtbrgy" runat="server" Class="txtbrgy" Visible="False">Staana</asp:TextBox>
                   

            </div>
             </section>
    </form>
</body>
</html>
