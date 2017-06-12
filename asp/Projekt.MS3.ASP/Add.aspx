<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="False" CodeBehind="Add.aspx.cs" Inherits="Projekt.MS3.Add" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
        <div id="info" runat="server" visible="false" style="padding: 5px; margin: 3px; background-color: #CCFFCC; text-align: center;">
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
    <table>
        <tr>
            <td class="auto-style2">Tytuł:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtTytul" runat="server" Width="481px"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="TytulCustomValidator" runat="server" ErrorMessage="Podany tekst musi zawierać min. 3 znaki." ForeColor="Red" ControlToValidate="txtTytul" ValidateEmptyText="True" OnServerValidate="TytulCustomValidator_ServerValidate" ValidationGroup="add"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Opis:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtOpis" runat="server" Height="104px" Width="481px" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Podany tekst musi zawierać min. 3 znaki." ForeColor="Red" ControlToValidate="txtOpis" ValidateEmptyText="True" ValidationGroup="add" OnServerValidate="TytulCustomValidator_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Autorzy:
                <br />
                (oddzieleni przecinkiem)
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtAutorzy" runat="server" Width="349px"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Podany tekst musi zawierać min. 3 znaki." ForeColor="Red" ControlToValidate="txtAutorzy" ValidateEmptyText="True" ValidationGroup="add" OnServerValidate="TytulCustomValidator_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Wydawnictwo:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtWydawnictwo" runat="server" Width="353px"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="Podany tekst musi zawierać min. 3 znaki." ForeColor="Red" ControlToValidate="txtWydawnictwo" ValidationGroup="add" OnServerValidate="TytulCustomValidator_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Oprawa:</td>
            <td class="auto-style1">
                <asp:DropDownList ID="ddOprawa" runat="server" Height="20px" Width="148px">
                    <asp:ListItem>miękka</asp:ListItem>
                    <asp:ListItem>twarda</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Wymiary (w mm):</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtWymiaryX" runat="server" Width="50px" MaxLength="3" TextMode="Number"></asp:TextBox>x<asp:TextBox ID="txtWymiaryY" runat="server" Width="50px" MaxLength="3" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="WymiaryXCustomValidator" runat="server" ErrorMessage="Błędny wymiar 1" ForeColor="Red" OnServerValidate="WymiaryCustomValidator_ServerValidate" ControlToValidate="txtWymiaryX" Display="Dynamic" ValidationGroup="add"></asp:CustomValidator>
                <asp:CustomValidator ID="WymiaryYCustomValidator" runat="server" ErrorMessage="Błędny wymiar 2" ForeColor="Red" OnServerValidate="WymiaryCustomValidator_ServerValidate" ControlToValidate="txtWymiaryY" Display="Dynamic" ValidationGroup="add"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Ilość stron:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtIloscStron" runat="server" MaxLength="5" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="IloscStronCustomValidator" runat="server" ErrorMessage="Ilość stron musi mieścić się w zakresie 1-99999" ForeColor="Red" OnServerValidate="IloscStronCustomValidator_ServerValidate" ControlToValidate="txtIloscStron" ValidationGroup="add"></asp:CustomValidator>
                </td>
        </tr>
        <tr>
            <td class="auto-style2">ISBN:</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtISBN" runat="server" Width="353px" MaxLength="17"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="ISBNRegularExpressionValidator" runat="server" ControlToValidate="txtISBN" ErrorMessage="Numer ISBN musi skłądać się z cyfr i/lub znaków &quot;-&quot;" ForeColor="Red" ValidationExpression="^[\d-]+$" ValidationGroup="add"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Okładka:<br />
                <asp:Image ID="imgOkldka" Height="200" Width="140" runat="server" />
            </td>
            <td class="auto-style1">
    <asp:FileUpload ID="FileUpload1" runat="server" Width="498px" />
            </td>
            <td>
                <asp:CustomValidator ID="FileUploadCustomValidator" runat="server" ErrorMessage="Plik musi mieć rozszerzenie .jpg lub .png." ForeColor="Red" ControlToValidate="FileUpload1" OnServerValidate="FileUploadCustomValidator_ServerValidate" ValidationGroup="add" ></asp:CustomValidator>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnZapisz" runat="server" Height="36px" Text="Zapisz" Width="520px" OnClick="btnZapisz_Click" ValidationGroup="add" />
    <asp:Button ID="btnUpdate" runat="server" Height="36px" Text="Aktualizuj" Width="520px" ValidationGroup="add" Visible="False" OnClick="btnUpdate_Click" />
    </asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 514px;
        }
        .auto-style2 {
            width: 212px;
        }
        .auto-styleButton {
            float:right;
        }
    </style>
</asp:Content>

