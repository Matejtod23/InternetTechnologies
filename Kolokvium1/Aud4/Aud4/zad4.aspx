<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zad4.aspx.cs" Inherits="Aud4.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-3">
                Телефонски број:
                <asp:TextBox ID="phone" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator1" 
                    runat="server" 
                    class="text-danger"
                    ErrorMessage="Пополнете го полето за телефонски број" 
                    ControlToValidate="phone"></asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator1" 
                    runat="server"
                    class="text-danger"
                    ErrorMessage="Невалиден телефонски број" 
                    ControlToValidate="phone" ValidationExpression="07[015678] ?[0-9]{3} ?[0-9]{3}"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="row-md-3">
                <asp:Button ID="save" runat="server" Text="Зачувај" OnClick="save_Click" />
            </div>

            <div class="row">
                <asp:Label ID="resault" runat="server"></asp:Label>
            </div>
    </div>
</asp:Content>
