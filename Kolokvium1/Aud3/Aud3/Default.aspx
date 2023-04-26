<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aud3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        

        <div class="row">
           <div class="col-m-4">
               Корисничко име:<br /> 
               <asp:TextBox ID="username" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator
                   ID="Validator1"
                   runat="server"
                   class="text-danger"
                   ErrorMessage="Корисничкото име е задолжително" 
                   ControlToValidate="username">
               </asp:RequiredFieldValidator>
           </div>

           <div class="col-m-4">
               Лозинка: <br />
               <asp:TextBox ID="password" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator
                   ID="Validator2"
                   runat="server"
                   class="text-danger"
                   ErrorMessage="Лозинката е задолжително" 
                   ControlToValidate="password">
               </asp:RequiredFieldValidator>          
           </div>

            <div class="col-m-4">
               Потврди лозинка: <br />
               <asp:TextBox ID="password_confirm" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator
                   ID="Validator3"
                   runat="server"
                   class="text-danger"
                   ErrorMessage="Ова поле е задолжително" 
                   ControlToValidate="password_confirm">
               </asp:RequiredFieldValidator>
               <br />
                <asp:CompareValidator 
                    ID="CmpValidator1" 
                    runat="server"
                    class="text-danger fw-bold"
                    ErrorMessage="Лозинките не се софпаѓаат" 
                    ControlToCompare="password" 
                    ControlToValidate="password_confirm">
                </asp:CompareValidator>
            </div>

            <div class="m-4">
                <asp:Button ID="Zacuvaj" runat="server" Text="Зачувај" />
            </div>

        </div>
    </main>

</asp:Content>
