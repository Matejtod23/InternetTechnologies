<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aud3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
      <div class="row">
          <div class="col-md-3">
              <asp:DropDownList ID="Cities" runat="server">
                  <asp:ListItem>(град)</asp:ListItem>
                  <asp:ListItem>Скопје</asp:ListItem>
                  <asp:ListItem>Велес</asp:ListItem>
                  <asp:ListItem>Охрид</asp:ListItem>
              </asp:DropDownList>

              <asp:RequiredFieldValidator 
                  ID="RequiredFieldValidator1" 
                  runat="server" 
                  ErrorMessage="Задолжително внесете град" 
                  ControlToValidate="Cities" 
                  InitialValue="(град)">
              </asp:RequiredFieldValidator>
          </div>
       
      </div>
      <div class="row-md-3">
              <asp:Button ID="Save" runat="server" Text="Зачувај" OnClick="Save_Click" />
                <br />
              <asp:Label ID="text" runat="server" Text=""></asp:Label>
          </div>
   </div>

</asp:Content>

