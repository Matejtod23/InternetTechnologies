<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Njava.aspx.cs" Inherits="Lab1._Default" %>

<asp:Content ID="webPageToLoad" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row-m-4">
            <p style="display:inline-block;margin-right:50px">Име:</p> <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1" 
                runat="server" 
                ErrorMessage="Внесете име" 
                ControlToValidate="name" ForeColor="Red"
                ></asp:RequiredFieldValidator>
        </div>

        <div class="row-m-3">
             <p style="display:inline-block;margin-right:25px">Лозинка:</p><asp:TextBox ID="password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator2" 
                runat="server" 
                ErrorMessage="Внесете лозника" 
                ControlToValidate="password" ForeColor="Red"
                ></asp:RequiredFieldValidator>
        </div>

        <div class="row-m-3">
             <p style="display:inline-block;margin-right: 23px">Е-адреса:</p><asp:TextBox ID="email" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator3" 
                runat="server" 
                ErrorMessage="Внесете емиал" 
                ControlToValidate="email" ForeColor="Red"
                ></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator 
                ID="RegularExpressionValidator1" 
                runat="server" 
                ErrorMessage="Невалиден формат" 
                ControlToValidate="email" 
                class="text-danger"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>

        <asp:Button ID="Save" runat="server" Text="Зачувај" OnClick="Save_Click"/>
        <br />
        
    </div>
</asp:Content>
