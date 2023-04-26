<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Plakjanje.aspx.cs" Inherits="Aud5.Plakjanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 text-center">
                <h1>Производи во кошнича</h1>
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12 text-center">
                <asp:ListBox ID="koshnicka" runat="server"></asp:ListBox>   
            </div>
        </div>
        <div class="row">
            <div class="col-xs-12">
                <asp:LinkButton ID="back" runat="server" OnClick="back_Click">< Каталог</asp:LinkButton>
            </div>
        </div>

        <div class="row">
            <div class="col-xs-12 text-center">
                <asp:Button ID="kupi" runat="server" Text="Купи" />
            </div>
        </div>
    </div>
</asp:Content>
