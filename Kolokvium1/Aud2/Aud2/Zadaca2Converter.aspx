<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Zadaca2Converter.aspx.cs" Inherits="Aud2.Zadaca2Converter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class"container-fluid">

        <div class="row text-center" style="height:300px">
            <div class="m-4">
                Внесете име на валута:
                <br/>
                <asp:TextBox ID="ImeValuta" runat="server"></asp:TextBox>
            </div>

            <div class="m-4">
                Внесете вредност на валута:
                <br />
                <asp:TextBox ID="VrednostValuta" runat="server"></asp:TextBox>
            </div>

            <div class="m-4" style="padding-left:5px">
                <asp:Button ID="DodadiValuta" runat="server" Text="Додади" OnClick="DodadiValuta_Click" />
                <asp:Button ID="IzbrisiValuta" runat="server" Text="Избриши" OnClick="IzbrisiValuta_Click" />
            </div>

            <hr />
            <div class="m-4">
                Внесете вредност: <asp:TextBox ID="Vrednost" runat="server" ></asp:TextBox><br/>
                <asp:Label ID="status" runat="server" Text=""></asp:Label>
            </div>
            
            
        </div>

        <div class="m-4">
                <asp:RadioButtonList ID="ListaValuta" runat="server" OnSelectedIndexChanged="ListaValuta_SelectedIndexChanged" AutoPostBack="True"></asp:RadioButtonList>
                Број на валути додадени: <asp:Label ID="BrojValuti" runat="server" Text="0"></asp:Label>
            </div>

    </div>
</asp:Content>
