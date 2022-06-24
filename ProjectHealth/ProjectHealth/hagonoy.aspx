<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hagonoy.aspx.cs" Inherits="ProjectHealth.hagonoy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="css/hagonoy.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
     <p><center> 
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Refresh" />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Staana</asp:ListItem>
            <asp:ListItem>Tuktukan</asp:ListItem>
        </asp:DropDownList>
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        HAGonoy Malalaa </center></p>
         
       
       
       
        <div class="scroll">

             <asp:GridView ID="GridView1" runat="server" Class="table table-condensed table-hover">
            </asp:GridView>
       

        </div>

            

         <div class="scroll2">
                 
        <asp:GridView ID="GridView2" runat="server" Class="table2 table-condensed2 table-hover2">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>
                 <asp:CheckBox ID="CheckBox2"   AutoPostBack="true"  text="delte"  runat="server" OnCheckedChanged="CheckBox2_CheckedChanged1" />
                     
                </HeaderTemplate>
                
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate> 
            </asp:TemplateField>
        </Columns>
        </asp:GridView>

        
        
        
        </div>
            


    
    </form>
</body>
</html>
