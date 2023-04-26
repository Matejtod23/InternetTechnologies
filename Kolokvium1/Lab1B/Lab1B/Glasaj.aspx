<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab1B.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Image ID="Image1" runat="server" 
                ImageUrl="https://www.finki.ukim.mk/sites/default/files/styles/large/public/default_images/finki_52_1_2_1_62_0.png?itok=miZDgQ_6" 
                style="width:300px"/><br />
            <asp:Label ID="lblProfesor" runat="server" Text=""></asp:Label>
        </div>
        <div class="row">
             <div class="col-2">
            <asp:ListBox ID="lbPredmeti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged">
               
            </asp:ListBox>
        </div>
        <div class="col-2">
            <asp:ListBox ID="lbKrediti" runat="server" AutoPostBack="True">
                
            </asp:ListBox>
        </div>
        </div>
        <asp:Label ID="result" runat="server" Text="" class="text-danger"></asp:Label><br />
        <asp:Button ID="save" runat="server" Text="Гласај" OnClick="save_Click" />
        <hr />
        <div class="d-flex flex-column">
            Предмет:<asp:TextBox ID="predmet" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Внесете Предемт" CssClass="text-danger" ControlToValidate="predmet" ValidationGroup="add"></asp:RequiredFieldValidator>
            Кредити:<asp:TextBox ID="kredit" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Внесете Кредит" ValidationGroup="add" CssClass="text-danger" ControlToValidate="kredit"></asp:RequiredFieldValidator>
           
            <asp:Button ID="add" runat="server" Text="Додади" style="width: 100px; margin-top: 5px" OnClick="add_Click" ValidationGroup="add" />

            <asp:Button ID="remove" runat="server" Text="Избриши" style="width: 100px; margin-top: 5px" OnClick="remove_Click"/>
        </div>
    </div>
</asp:Content>
