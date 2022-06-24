<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SAAccount.aspx.cs" Inherits="ProjectHealth.SAAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Health Center ADMIN</title>
      <link href="css/SAAccount.css" rel="stylesheet" />
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

           <!--------------------------------------->

         <div class="content">

               <asp:Label ID="Label7" runat="server" class="content title1" Text="Account"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="tagline1" Text="Username and Password"></asp:Label>

               <!--------------------------------------->
                     
                         
                

         <div class="scroll">
             <asp:GridView ID="GridView7" runat="server" Class="table7 table-condensed7 table-hover7">
                  <Columns>
             
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
                 
                   <asp:TextBox ID="txtusernames" runat="server" class="txtusernames" Visible="False"></asp:TextBox>
                  <asp:TextBox ID="txtpasswords" runat="server" class="txtpasswords"></asp:TextBox>
                
                  

                  <asp:TextBox ID="txtbrgy" runat="server"  class="txtbrgy" Visible="False" ></asp:TextBox>

                  <asp:Label ID="Label2" runat="server" Text="Username :" class="username" Visible="False"></asp:Label>
                  <asp:Label ID="Label3" runat="server" Text="Password :" class="password"></asp:Label>
                  <asp:Label ID="Label4" runat="server" Text="Barangay :" class="barangay" Visible="False"></asp:Label>
            
            </div>

             
             <asp:Button ID="update" runat="server" Text="Update" Class="Update" OnClick="update_Click" />
             <asp:Button ID="clear" runat="server" Text="Clear" Class="Clear" OnClick="clear_Click" />



             </div>


    </form>
</body>
</html>
