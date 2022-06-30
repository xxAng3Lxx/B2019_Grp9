<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TUStaff.aspx.cs" Inherits="ProjectHealth.TUStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Tuktukan ADMIN</title>
      <link href="css/TUStaff.css" rel="stylesheet" />
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
       
            <asp:Label ID="Label7" runat="server" class="content title1" Text="Staff"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="tagline1" Text="Health Center Member"></asp:Label>
           
                           
                          
                           
                
            <div class="scroll">
            <asp:GridView ID="GridView5" runat="server" Class="table table-condensed table-hover">

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

                 <!----filupppppppppppppppppppppppppppppppppppppppppp---->
              <div class="fillup">
             
                <asp:TextBox ID="txtid" runat="server" Visible="False"></asp:TextBox>
                 
                   <asp:TextBox ID="txtname" runat="server" class="txtname"></asp:TextBox>
                  <asp:TextBox ID="txtposition" runat="server" class="txtposition"></asp:TextBox>
                 
                  
                   
                 
                 <asp:TextBox ID="txtbrgy" runat="server" class="txtbrgy" Enabled="True" >Tuktukan</asp:TextBox>




                  <asp:Label ID="Label2" runat="server" Text="Name :" class="name"></asp:Label>
                  <asp:Label ID="Label3" runat="server" Text="Position :" class="position"></asp:Label>
                  <asp:Label ID="Label4" runat="server" Text="Barangay :" class="barangay"></asp:Label>
            
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
