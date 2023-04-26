<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="Lab1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="lblProfesor" runat="server" Text=""></asp:Label>
            <div class="col-md-2">              
                <asp:ListBox ID="lbPredmeti" runat="server" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem Value="Проф. д-р Гоце Арменски">Интернет Технологии</asp:ListItem>
                    <asp:ListItem Value="Проф д-р Миле Јованов">Интернет</asp:ListItem>
                    <asp:ListItem Value="Проф. д-р Ристе Стојанов">Дигитална Електроника</asp:ListItem>
                </asp:ListBox>
            </div>
            <div class="col-md-3">
                <asp:ListBox ID="lbKrediti" runat="server">
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>5.5</asp:ListItem>
                    <asp:ListItem>5.5</asp:ListItem>
                </asp:ListBox>
            </div>
        </div>
        <div class="col-md-3">
            <asp:Button ID="save" runat="server" Text="Зачувај" OnClick="save_Click" />
        </div>
        <div class="col-sm-4">
            <asp:Label ID="result" runat="server" Text="" CssClass="text-danger"></asp:Label>
        </div>
    </div>
</asp:Content>
