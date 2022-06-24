<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuktukanprenatal.aspx.cs" Inherits="ProjectHealth.tuktukanprenatal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tuktukan Health Center</title>
      <link href="css/tuktukanprenatal.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <section class="hero" id="hero">
            
                <div class="nav">
         
                  
                    <asp:Button ID="homepage" runat="server" OnClick="homepage_Click" Text="Health Center" Class="hoome" />
                    <asp:Button ID="tuktukan" runat="server" OnClick="tuktukan_Click" Text="Tuktukan" Class="navhome" />
                    <asp:Button ID="tuktukancheck" runat="server" OnClick="tuktukancheck_Click" Text="Checkup" Class="navcheckup" />
                    <asp:Button ID="tuktukanpre" runat="server" OnClick="tuktukanpre_Click" Text="Prenatal" Class="navprenatal" />
         
                  
                </div>

        <asp:Label ID="Label1" runat="server" class="headingss" Text="Prenatal"></asp:Label>
        <asp:Label ID="Label2" runat="server" class="sentence1" Text="Prenatal care is a checkups from a doctor, nurse, or midwife throughout your pregnancy. It helps keep you and your future baby healthy."></asp:Label>
        <asp:Label ID="Label3" runat="server" class="sentence2" Text="prenatal care can help prevent complications and inform women about important steps they	can take to protect their infant and ensure a healthy pregnancy"></asp:Label>



          <a href="#villain" class="btnsection"> Prenatal Reservation</a>
        <img src="imagess/e86b8ce1153103ff077d55825a9b58ba--pregnancy-and-birth-births.jpg" class="image1" />
        <img src="imagess/pregnancy-birth-infographics-presentation-template-icon-icons-set-49086256.jpg" class="image2" />
        <img src="imagess/stock-vector-pregnant-woman-diet-infographic-a-food-guide-for-pregnant-woman-pregnant-diet-healthy-lifestyle-1014944494.jpg" class="image3" />
          </section>



        <section class="villain" id="villain">
           
           

            <asp:Label ID="Label4" runat="server" class="title1"      Text="Appointment"></asp:Label>
            <asp:Label ID="Label5" runat="server" class="title2"        Text="Prenatal  Reservation"></asp:Label>

                     
                        <div class="cfillup">
         
        
                            <asp:TextBox ID="txtpname" runat="server" Class="txtpname"></asp:TextBox>
                            <asp:TextBox ID="txtpage" runat="server" Class="txtpage"></asp:TextBox>
                            <asp:TextBox ID="txtpaddress" runat="server" Class="txtpaddress"></asp:TextBox>
                            <asp:TextBox ID="txtpcontact" runat="server" Class="txtpcontact"></asp:TextBox>
                            <asp:TextBox ID="txtpdate" runat="server" type="date" Class="txtpdate"></asp:TextBox>
                            <asp:TextBox ID="txtbrgy" runat="server" Class="txtbrgy" Visible="False">Tuktukan</asp:TextBox>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Class="buttonsubmit" />
         

                            <asp:Label ID="Label6" runat="server" class="cfillup FullName"  Text="FullName:"></asp:Label>
                            <asp:Label ID="Label7" runat="server" class="cfillup Age"       Text="Age:"></asp:Label>
                            <asp:Label ID="Label8" runat="server" class="cfillup Address"   Text="Address:"></asp:Label>
                            <asp:Label ID="Label9" runat="server" class="cfillup Date"      Text="Date:"></asp:Label>        
                            <asp:Label ID="Label10" runat="server" class="cfillup Contact"  Text="Contact:"></asp:Label>

                        </div>
          </section>

    </form>
</body>
</html>
