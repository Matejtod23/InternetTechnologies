<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aud5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12 text-center">
        <b>Категории</b>
    </div>

    <div class="row">
        <div class="col-offset-4 col-md-8">
            <asp:LinkButton ID="sl" runat="server" OnClick="sl_Click">Стручна литература</asp:LinkButton>
            <br />
            <asp:LinkButton ID="be" runat="server" OnClick="be_Click">Белетристика</asp:LinkButton>
            <br />
            <asp:LinkButton ID="sp" runat="server" OnClick="sp_Click">Списанија</asp:LinkButton>
        </div>
    </div>

</asp:Content>
