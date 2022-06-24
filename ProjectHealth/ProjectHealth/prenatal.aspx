<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prenatal.aspx.cs" Inherits="ProjectHealth.prenatal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Health Center ADMIN</title>
      <link href="css/prenatal.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="nav">
    
        <img src="imagess/City_of_Taguig_Seal.png" class="logo"/>
        <asp:Label ID="Label9" runat="server" class="logotitle" Text="Taguig City"></asp:Label>
        
       
      <hr class="hrr"/>

        
        <asp:Button ID="Dashboard" runat="server" OnClick="Button1_Click" Text="Dashboard" class="button1" /> <div class="image1"></div>
        <asp:Button ID="Button2" runat="server" Text="Checkup" OnClick="Button2_Click" class="button2" /><div class="image2"></div>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Prenatal" class="button3" />   <div class="image3"></div>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Category" class="button4" /><div class="image4"></div>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Staff" class="button5" /> <div class="image5"></div>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Account" class="button6" />  <div class="image6"></div>  
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Logout" class="button8" />  <div class="image8"></div>

        
                                                                                                            
    </div>

        <div class="content">
       
            <asp:Label ID="Label7" runat="server" class="content title1" Text="Prenatal"></asp:Label>
            <asp:Label ID="Label8" runat="server" class="tagline1" Text="Mothers Record"></asp:Label>


        
            <div class="scroll">
            <asp:GridView ID="GridView2" runat="server" Class="table table-condensed table-hover">

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

            <!------------------------------------>

            <div class="fillup">

      

                 <asp:TextBox ID="txtid" runat="server" class="txtnumbers" Visible="False"></asp:TextBox>
                <asp:TextBox ID="txtmname" runat="server" class="txtmname"></asp:TextBox>
                <asp:TextBox ID="txtage" runat="server" class="txtage"></asp:TextBox>
                <asp:TextBox ID="txtaddress" runat="server" class="txtaddress" ></asp:TextBox>
                <asp:TextBox ID="txtdate" runat="server" type="date"  class="txtdate" ></asp:TextBox>
                <asp:TextBox ID="txtcontact" runat="server" class="txtcontact" ></asp:TextBox>
                <asp:DropDownList ID="txtbrgy" runat="server" class="txtbrgy" >
                    <asp:ListItem>Staana</asp:ListItem>
                    <asp:ListItem>Tuktukan</asp:ListItem>
                    <asp:ListItem>NorthSignal</asp:ListItem>
                </asp:DropDownList>

                <!---------------tect--------------------->
                <asp:Label ID="Label1" runat="server" Text="MotherName :" class="MotherName" ></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Age :"  class="Age" ></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Address :" class="Address" ></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Date :" class="Date" ></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="Contact :" class="Contact" ></asp:Label>
                <asp:Label ID="Label6" runat="server" Text="Brgy :" class="Brgy" ></asp:Label>


                


            </div>



           <asp:Button ID="delete" runat="server" OnClick="delete_Click" Text="Delete"  Class="Delete" OnClientClick="Confirm()" />
            <asp:Button ID="update" runat="server" OnClick="update_Click" Text="Update"  Class="Update" />
            <asp:Button ID="clear" runat="server" OnClick="clear_Click" Text="Clear"  Class="Clear" />



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
