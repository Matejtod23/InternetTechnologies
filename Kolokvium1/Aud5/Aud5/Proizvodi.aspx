<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Proizvodi.aspx.cs" Inherits="Aud5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-8 text-center">
            <asp:Label ID="naslov" runat="server" Text="(none)"></asp:Label>
        </div>
        <div class="row">
            <div class="col-md-6">
                <p class="m-0">Наслови</p><br />
                <asp:ListBox ID="naslovi" runat="server" Height="250px" Width="850px" AutoPostBack="true" OnSelectedIndexChanged="naslovi_SelectedIndexChanged"></asp:ListBox>
            </div>

            <div class="col-md-5">
                <p class="m-0">Цени</p><br />
                <asp:ListBox ID="ceni" runat="server" Height="250px" Width="850px" AutoPostBack="true"></asp:ListBox>
            </div>
        </div>

        <div class="row mt-2">
            <div class="col-7">
                <asp:Button ID="add" runat="server" Text="Додади" OnClick="add_Click" />
                <hr />
                <asp:ListBox ID="koshnicka" runat="server"></asp:ListBox>
                <hr />
                <asp:Button ID="kupi" runat="server" Text="Купи" OnClick="kupi_Click" />
            </div>
            <div class="col-2">
                Тотал:
                <asp:Label ID="total" runat="server" Text="0"></asp:Label>
            </div>
        </div>
        
        
    </div>
</asp:Content>
