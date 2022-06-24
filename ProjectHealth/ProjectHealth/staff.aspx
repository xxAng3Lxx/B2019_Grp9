<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="staff.aspx.cs" Inherits="ProjectHealth.staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Health Center ADMIN</title>
      <link href="css/staff.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="nav">
    
        <img src="imagess/City_of_Taguig_Seal.png" class="logo"/>
        <asp:Label ID="Label9" runat="server" class="logotitle" Text="Taguig City"></asp:Label>
        
       
      <hr class="hrr"/>

        
        <asp:Button ID="Dashboard" runat="server" OnClick="Button1_Click" Text="Dashboard" class="button1" /> <div class="image1"></div>
        <asp:Button ID="checkup" runat="server" Text="Checkup" OnClick="Button2_Click" class="button2" /><div class="image2"></div>
        <asp:Button ID="pre" runat="server" OnClick="Button3_Click" Text="Prenatal" class="button3" />   <div class="image3"></div>
        <asp:Button ID="category" runat="server" OnClick="Button4_Click" Text="Category" class="button4" /><div class="image4"></div>
        <asp:Button ID="staf" runat="server" OnClick="Button5_Click" Text="Staff" class="button5" /> <div class="image5"></div>
        <asp:Button ID="account" runat="server" OnClick="Button6_Click" Text="Account" class="button6" />  <div class="image6"></div>  
        <asp:Button ID="loogout" runat="server" OnClick="Button7_Click" Text="Logout" class="button8" />  <div class="image8"></div>

      
                                                                                                            
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

              <!----searchhhhhhhhhhhhhhhhh---->

            <asp:Button ID="search" runat="server" OnClick="search_Click" Text="Load" class="refresh" />
            <asp:DropDownList ID="ddsearch" runat="server" class="dropdown" AutoPostBack="True" OnSelectedIndexChanged="ddsearch_SelectedIndexChanged">
                <asp:ListItem>Staana</asp:ListItem>
                <asp:ListItem>Tuktukan</asp:ListItem>
                <asp:ListItem>NorthSignal</asp:ListItem>
            </asp:DropDownList>

                  <!----filupppppppppppppppppppppppppppppppppppppppppp---->
              <div class="fillup">
             
                <asp:TextBox ID="txtid" runat="server" Visible="False"></asp:TextBox>
                 
                   <asp:TextBox ID="txtname" runat="server" class="txtname"></asp:TextBox>
                  <asp:TextBox ID="txtposition" runat="server" class="txtposition"></asp:TextBox>
                  <asp:DropDownList ID="txtbrgy" runat="server" class="txtbrgy">
                      <asp:ListItem>Staana</asp:ListItem>
                      <asp:ListItem>Tuktukan</asp:ListItem>
                      <asp:ListItem>NorthSignal</asp:ListItem>
                  </asp:DropDownList>

                  <asp:Label ID="Label1" runat="server" Text="Name :" class="name"></asp:Label>
                  <asp:Label ID="Label2" runat="server" Text="Position :" class="position"></asp:Label>
                  <asp:Label ID="Label3" runat="server" Text="Barangay :" class="barangay"></asp:Label>
            
            </div>

             <asp:Button ID="add" runat="server"  Text="Add"   Class="Add" OnClick="add_Click" /> 
             <asp:Button ID="update" runat="server" Text="Update" Class="Update" OnClick="update_Click" />
             <asp:Button ID="delete" runat="server" Text="Delete" Class="Delete" OnClick="delete_Click" />
             <asp:Button ID="clear" runat="server" Text="Clear" Class="Clear" OnClick="clear_Click" />



             </div>


    </form>
</body>
</html>
