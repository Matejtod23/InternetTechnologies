<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aud2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            
        </section>

        <div class="row" style="height : 300px">
            <div class="col-md-17 text-center">
                Изберете град<br />
                <asp:ListBox ID="ListaGradovi" runat="server" SelectionMode="Multiple">
                    <asp:ListItem Value="0km">Скопје</asp:ListItem>
                    <asp:ListItem Value="50km">Велес</asp:ListItem>
                    <asp:ListItem Value="200km">Охрид</asp:ListItem>
                </asp:ListBox>
                <div class="m-3">
                    <asp:Button ID="PrikaziGrad" runat="server" Text="Прикажи град" OnClick="PrikaziGrad_Click" />
                </div>
                <div class="m-3">
                    Селектираниот град е: <asp:Label ID="SelektiranGrad" runat="server" Text="(none)"></asp:Label>
                </div>
                <div class="m-3">
                    Одалеченоста од Скопје е: <asp:Label ID="Odalecenost" runat="server" Text="(none)"></asp:Label>
                </div>
            </div>

        </div>
    </main>

</asp:Content>
