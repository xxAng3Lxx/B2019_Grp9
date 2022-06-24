<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SACheckup.aspx.cs" Inherits="ProjectHealth.SACheckup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Health Center ADMIN</title>
      <link href="css/SACheckup.css" rel="stylesheet" />
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


         <div class="content">
       

       <asp:Label ID="Label10" runat="server" class="content title1" Text="Checkup"></asp:Label>
       <asp:Label ID="Label11" runat="server" class="content tagline1" Text="Patient Record"></asp:Label>

                     
                          
               

        <div class="scroll">
             <asp:GridView ID="GridView1" runat="server" Class="table table-condensed table-hover"> 
           <Columns>
               <asp:TemplateField>
                   
                   <HeaderTemplate>
                       <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox2_CheckedChanged" />
                    </HeaderTemplate>

                   <ItemTemplate>
                       <asp:CheckBox ID="CheckBox1" runat="server" />
                   </ItemTemplate>


                   

               </asp:TemplateField>
               <asp:TemplateField>
                     <ItemTemplate>
                         <asp:Button ID="Button15" runat="server" OnClick="Button15_Click" Text="Select" Class="selects"   />
                    </ItemTemplate>


                   
               </asp:TemplateField>
           </Columns>

       </asp:GridView>
        </div>

             <!------------------------------------------------->

             <div class="fillup">

           <asp:TextBox ID="txtid" runat="server" class="txtnumbers" Visible="False"></asp:TextBox>
           <asp:TextBox ID="txtothers" runat="server" class="txtothers" ></asp:TextBox>
           <asp:TextBox ID="txtdate" runat="server" type="date" class="txtdate" ></asp:TextBox>
           <asp:TextBox ID="txtcontact" runat="server" class="txtcontact" ></asp:TextBox>
           <asp:TextBox ID="txtage" runat="server" class="txtage" ></asp:TextBox>
           <asp:TextBox ID="txtaddress" runat="server" class="txtaddress" ></asp:TextBox>
           <asp:TextBox ID="txtpatient" runat="server" class="txtpatient" ></asp:TextBox>
           <asp:DropDownList ID="txtillness" runat="server" class="txtillness" >
               <asp:ListItem></asp:ListItem>
           </asp:DropDownList>
           
            
           <asp:TextBox ID="txtbgry" runat="server" class="txtbgry" Enabled="True" >Staana</asp:TextBox>



           <asp:DropDownList ID="txtgender" runat="server" class="txtgender">
               <asp:ListItem>Male</asp:ListItem>
               <asp:ListItem>Female</asp:ListItem>
           </asp:DropDownList>


           
           <asp:Label ID="Label2" runat="server" class="patient"      Text="Fullname:"></asp:Label>
           <asp:Label ID="Label3" runat="server" class="address"      Text="Address:"></asp:Label>
           <asp:Label ID="Label4" runat="server" class="age"      Text="Age:"></asp:Label>
           <asp:Label ID="Label5" runat="server" class="contact"      Text="Contact:"></asp:Label>
           <asp:Label ID="Label6" runat="server" class="date"      Text="Reservation:"></asp:Label>

           <asp:Label ID="Label7" runat="server" class="gender"      Text="Gender:"></asp:Label>
           <asp:Label ID="Label8" runat="server" class="brgy"      Text="Barangay:"></asp:Label>
           <asp:Label ID="Label9" runat="server" class="illness"      Text="Illness:"></asp:Label>


       </div>
          <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Update" Class="Update"  />
           <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Delete" Class="Delete" OnClientClick="Confirm()" />
           <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="Clear" Class="Clear" />






             </div>
    </form>

    <!------------------------------------------>

    <script type = "text/javascript">
        function Confirm() {
            var confirm_value = document.createElement("INPUT");

            confirm_value.type = "hidden";
            confirm_value.name = "confirm_value";

            if (confirm("Do you want to DELETE this Data?")) {
                confirm_value.value = "Yes";
            }
            else {
                confirm_value.value = "No";
            }

            document.forms[0].appendChild(confirm_value);
        }
    </script>

</body>
</html>
