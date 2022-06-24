<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="ProjectHealth.category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Health Center ADMIN</title>
      <link href="css/category.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="nav">
    
         <img src="imagess/City_of_Taguig_Seal.png" class="logo"/>
         <asp:Label ID="Label9" runat="server" class="logotitle" Text="Taguig City"></asp:Label>
        
       
       <hr class="hrr"/>

        
                                                                                                            
        <asp:Button ID="dashboard" runat="server" OnClick="dashboard_Click" Text="Dashboard" class="button1" /> <div class="image1"></div>
        <asp:Button ID="checkup" runat="server" OnClick="checkup_Click" Text="Checkup" class="button2" /> <div class="image2"></div>
        <asp:Button ID="prenatal" runat="server" OnClick="prenatal_Click" Text="Prenatal" class="button3" /> <div class="image3"></div>
        <asp:Button ID="catgry" runat="server" OnClick="catgry_Click" Text="Category" class="button4" /> <div class="image4"></div>
        <asp:Button ID="staff" runat="server" OnClick="staff_Click" Text="Staff" class="button5" /> <div class="image5"></div>
        <asp:Button ID="Account" runat="server" OnClick="Account_Click" Text="Account" class="button6" /> <div class="image6"></div>  
        <asp:Button ID="logout" runat="server" OnClick="logout_Click" Text="Logout" class="button8" />  <div class="image8"></div>

                                                                                                            
    </div>


        <!--------------------------------------->

         <div class="content">

               <asp:Label ID="Label7" runat="server" class="content title1" Text="Category"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="tagline1" Text="Illness Monitoring"></asp:Label>

       <!--------------------------------------->


         <div class="scroll">
             <asp:GridView ID="GridView3" runat="server" Class="table table-condensed table-hover">

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
             
          <!------------------------tavleeeeeeeeeeeeeeeeeeeeeee22222222222222222222-------------------->   
              <div class="scroll2">
                  <asp:GridView ID="GridView4" runat="server"  Class="table2 table-condensed2 table-hover2"></asp:GridView>
                </div>
             
              <!---------------formmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm--------------------->

            <div class="fillup">
             
                <asp:TextBox ID="txtill" runat="server" class="txtill"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Illness" class="illness"></asp:Label>


                <asp:TextBox ID="txtid" runat="server" Visible="False"></asp:TextBox>
            
            </div>

             <asp:Button ID="add" runat="server"  Text="Add"   Class="Add" OnClick="add_Click" /> 
             <asp:Button ID="update" runat="server" Text="Update" Class="Update" OnClick="update_Click" />
             <asp:Button ID="delete" runat="server" Text="Delete" Class="Delete" OnClick="delete_Click" />
             <asp:Button ID="clear" runat="server" Text="Clear" Class="Clear" OnClick="clear_Click" />
         </div>

    </form>
</body>
</html>
