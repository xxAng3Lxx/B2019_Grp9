<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staanacheckup.aspx.cs" Inherits="ProjectHealth.staanacheckup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>STA ANA Health Center</title>
      <link href="css/staanacheckup.css" rel="stylesheet" />
      
</head>
<body>
    <form id="form1" runat="server">
    
        <section class="hero" id="hero">
            


            <div class="nav">


        
            <asp:Button ID="homepage" runat="server" OnClick="homepage_Click" Text="Health Center" Class="hoome" />
            <asp:Button ID="staana" runat="server" OnClick="staana_Click" Text="StaAna" Class="navhome" />
            <asp:Button ID="checkup" runat="server" OnClick="checkup_Click" Text="Checkup" Class="navcheckup" />
            <asp:Button ID="prenatal" runat="server" OnClick="prenatal_Click" Text="Prenatal" Class="navprenatal"/>
            
                </div>


                <asp:Label ID="Label1" runat="server" class="headingss" Text="Check-up for Patient"></asp:Label>
            <asp:Label ID="Label2" runat="server" class="sentence1" Text="Health and fitness is always a priority for everyone.Undergoing a health checkup regularly can help you to be safe from health problems"></asp:Label>

            <asp:Label ID="Label3" runat="server" class="sentence2" Text="Everyone is welcome to participate in our Checkup (Children, Teenagers, Parents and Adults)	It's a free checkup, and there's also free treatment
thereafter. since our goal is to find a treatment for	their illness"></asp:Label>
            
            
            
              <!--- <asp:Button ID="section" runat="server" Text="Resevation Check up" Class="btnsection" href="#villain" />--->

            	 <a href="#villain" class="btnsection"> Check up Reservation</a>
        

            <img src="imagess/foods.jpg" class="image1" />
            <img src="imagess/infographics-healthy-life-illustration-40145138.jpg" class="image2"/>





        </section>

        <section class="villain" id="villain">
           
            

            <asp:Label ID="Label4" runat="server" class="title1" Text=" Appointment "></asp:Label>
            <asp:Label ID="Label5" runat="server" class="title2" Text="Check up  Reservation"></asp:Label>

        <div class="cfillup">
         
           

            <asp:TextBox ID="txtpatient" runat="server" Class="txtpatient"></asp:TextBox>
            <asp:TextBox ID="txtaddress" runat="server" Class="txtaddress"></asp:TextBox>
            <asp:TextBox ID="txtage" runat="server" Class="txtage"></asp:TextBox>
            <asp:TextBox ID="txtcontact" runat="server" Class="txtcontact"></asp:TextBox>
            <asp:TextBox ID="txtdate" runat="server" type="date" Class="txtdate"></asp:TextBox>
            <asp:DropDownList ID="txtillness" runat="server" Class="txtillness">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Headache</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtothers" runat="server" Class="txtothers"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Class="buttonsubmit" />
        
                  
            <asp:Label ID="Label6" runat="server" class="cfillup patient"      Text="Patient Name:"></asp:Label>
            <asp:Label ID="Label7" runat="server" class="cfillup address"      Text="Address:"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="cfillup age"      Text="Age:"></asp:Label>
            <asp:Label ID="Label9" runat="server" class="cfillup contact"     Text="Contact:"></asp:Label>
            <asp:Label ID="Label10" runat="server" class="cfillup date"     Text="Reserve Date:"></asp:Label>
            <asp:Label ID="Label11" runat="server"   class="cfillup illness"    Text="Illness:"></asp:Label>
            <asp:Label ID="Label12" runat="server"   class="cfillup others"    Text="Others:"></asp:Label>
            <asp:Label ID="Label13" runat="server"   class="cfillup gender"   Text="Gender:"></asp:Label>

        
            <asp:TextBox ID="txtbrgy" runat="server" Class="txtbrgy" Visible="False">Staana</asp:TextBox>

        
        
            <asp:DropDownList ID="txtgender" runat="server" Class="txtgender">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>

        
        
        </div>
             </section>



    </form>
</body>
</html>
