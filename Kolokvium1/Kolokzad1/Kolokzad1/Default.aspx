<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kolokzad1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="panel1" runat="server">
        <div class="container" ID="container">
        <div class="col-7">
            <div class="d-flex">
                <p>Корисничко име:</p>
                <asp:TextBox ID="name" runat="server" Height="30px" style="margin-left: 20px"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator1"
                    runat="server" 
                    ErrorMessage="Внесете име"
                    ControlToValidate="name"
                    class="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator1" 
                    runat="server" 
                    ErrorMessage="Невалиден формат" 
                    ControlToValidate="name" 
                    class="text-danger"
                    ValidationExpression="\w+[\^!-]+"></asp:RegularExpressionValidator>
            </div>
            <div class="d-flex">
                <p>Лозинка:</p>
                <asp:TextBox ID="password" runat="server" Height="30px" style="margin-left: 80px"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator2"
                    runat="server" 
                    ErrorMessage="Внесете лозинка"
                    ControlToValidate="password"
                    class="text-danger"></asp:RequiredFieldValidator>           
            </div>
            <div class="d-flex">
                <p>Емаил:</p>
                <asp:TextBox ID="email" runat="server" Height="30px" style="margin-left: 95px"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator3"
                    runat="server" 
                    ErrorMessage="Внесете емиал"
                    ControlToValidate="email"
                    class="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator2" 
                    runat="server" 
                    ErrorMessage="Невалиден формат" 
                    ControlToValidate="email" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div> 
            
            <asp:Button ID="najava" runat="server" Text="Најави се" OnClick="najava_Click" />
        </div>
    </asp:Panel>
    

    <asp:Panel ID="panel2" runat="server" Visible="false">
        <div class="row mt-5" ID="ContainerDiv">
            <div class="col-6">
                <asp:ListBox ID="lstZanrovi" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstZanrovi_SelectedIndexChanged">
                    <asp:ListItem>Драма</asp:ListItem>
                    <asp:ListItem>Комедија</asp:ListItem>
                    <asp:ListItem>Акција</asp:ListItem>
                </asp:ListBox>
                <asp:Image ID="Image1" runat="server" ImageUrl="https://icon2.cleanpng.com/20180429/uhq/kisspng-popcorn-cinema-systems-corp-film-reel-5ae62786a25f44.8526976815250328386651.jpg" style="margin-left: 50px; height: 200px"/>
            </div>
        </div>
        <div class="col-7">
            <asp:CheckBox ID="box1" runat="server"/>
            <asp:TextBox ID="txtKolichina1" runat="server" AutoPostBack="True" OnTextChanged="txtKolichina1_TextChanged"></asp:TextBox><br />
            <asp:CheckBox ID="box2" runat="server"/>
            <asp:TextBox ID="txtKolichina2" runat="server" AutoPostBack="true" OnTextChanged="txtKolichina2_TextChanged"></asp:TextBox><br />
            <asp:CheckBox ID="box3" runat="server"/>
            <asp:TextBox ID="txtKolichina3" runat="server" AutoPostBack="True" OnTextChanged="txtKolichina3_TextChanged"></asp:TextBox><br />
            <asp:Button ID="buy" runat="server" Text="Купи" style="margin-top:20px" OnClick="buy_Click"/>
        </div>
        Вкупната цена изнесува <asp:Label ID="cena" runat="server" Text="0"></asp:Label>
    </div>
    </asp:Panel>

        

</asp:Content>
