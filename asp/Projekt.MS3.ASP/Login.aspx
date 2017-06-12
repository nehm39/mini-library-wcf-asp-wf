<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projekt.MS3.Login" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" DefaultButton="ButtonZaloguj">
    <div style="text-align: center">
        <asp:Label ID="Label1" runat="server" Text="Login:"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxLogin" runat="server" Width="190px">admin</asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Hasło:"></asp:Label>&nbsp;<asp:TextBox ID="TextBoxHaslo" runat="server" Width="190px" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonZaloguj" runat="server" Text="Zaloguj" OnClick="ButtonZaloguj_Click" />
        <div id="error" runat="server">
            <br />
            <asp:Label ID="LabelError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </div>
        </asp:Panel>

</asp:Content>
