<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="zad1.aspx.cs" Inherits="Aud4._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="margin: 20px">
        <div class="row">
            <div class="col-md-3">
                Име на испит:<br />
                <asp:TextBox ID="exam_name" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-9 text-left">
                <%--validator--%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                    runat="server" 
                    ErrorMessage="Задолжително внесете име"
                    class="text-danger"
                    ControlToValidate="exam_name">
                </asp:RequiredFieldValidator>
            </div>
        </div>

         <div class="row">
            <div class="col-md-3">
                Датум на испит:
                <asp:TextBox ID="exam_date" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-9 text-left">
                <%--validator--%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                    runat="server" 
                    ErrorMessage="Задолжително внесете датум"
                    class="text-danger"
                    ControlToValidate="exam_date">
                </asp:RequiredFieldValidator>
               
                <asp:CompareValidator 
                    ID="CompareValidator1" 
                    runat="server" 
                    class="text-danger"
                    ControlToValidate="exam_date"
                    ErrorMessage="Невалидна вредност за датумот" 
                    ValueToCompare="22-03-2023" Operator="LessThanEqual"></asp:CompareValidator>

            </div>
        </div>

        <div class="row">
            <div class="col-md-3">
                Добиена оцена:
                <asp:TextBox ID="grade" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-9 text-left">
                <%--validator--%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                    runat="server" 
                    ErrorMessage="Задолжително внесете оцена"
                    class="text-danger"                    
                    ControlToValidate="grade">
                </asp:RequiredFieldValidator>

                <asp:RangeValidator 
                    ID="RangeValidator1" 
                    runat="server" 
                    ErrorMessage="Невалидна оцена" 
                    ControlToValidate="grade" 
                    class="text-danger"
                    Type="Integer" MaximumValue="10" MinimumValue="5"></asp:RangeValidator>
            </div>
        </div>

        <div class="row" style="margin-left: 0; margin-top: 10px">
            <asp:Button ID="save" runat="server" Text="Зачвуај" OnClick="save_Click" style="width: 100px"/>
        </div>

        <div class="row">
            <asp:Label ID="resault" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
