<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Projekt.MS3.Search" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="ListView1" runat="server">
        <EmptyDataTemplate>
            Brak wyników. Spróbuj ponownie używając wyszukiwania zaawansowanego.
            <br /><br />
        </EmptyDataTemplate>
        <ItemSeparatorTemplate>
            <br />
        </ItemSeparatorTemplate>
        <ItemTemplate>
            <li>
                <asp:HyperLink ID="K_TYTULLabel" runat="server" Text='<%# string.Format("{0}", Eval("tytul")) %>' NavigateUrl='<%# string.Format("~/Show.aspx?id={0}", Eval("Id")) %>' /></li>
        </ItemTemplate>
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" style="">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="">
                <asp:DataPager ID="DataPager1" runat="server">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" FirstPageText="Pierwsza" />
                        <asp:NumericPagerField ButtonCount="10" />
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" LastPageText="Ostatnia" />
                    </Fields>
                </asp:DataPager>
                <br />
                <br />

            </div>
        </LayoutTemplate>
    </asp:ListView>
    <asp:Panel ID="PanelZaawansowane" runat="server" BorderStyle="Double" DefaultButton="btnSzukanieZaawansowane">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Szukany tekst:</td>
                <td>
                    <asp:TextBox ID="txtSzukanyTekst" runat="server" Width="450px"></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="SzukanyTekstCustomValidator" runat="server" ControlToValidate="txtSzukanyTekst" ErrorMessage="Szukany tekst musi składać się z minimum 3 znaków" ForeColor="Red" OnServerValidate="SzukanyTekstCustomValidator_ServerValidate" ValidateEmptyText="True" ValidationGroup="zaawansowaneGroup"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td>
                    <asp:CheckBox ID="chbxSzukajWOpisie" runat="server" Text="Szukaj w tytule i w opisie" /></td>
            </tr>
            <tr>
                <td class="auto-style2">Autor:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtAutor" runat="server" Width="155px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Wydawnictwo:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtWydawnictwo" runat="server" Width="153px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Oprawa:</td>
                <td>
                    <asp:DropDownList ID="ddOprawa" runat="server">
                        <asp:ListItem Selected="True" Value="default">dowolna</asp:ListItem>
                        <asp:ListItem>miękka</asp:ListItem>
                        <asp:ListItem>twarda</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ilość stron:</td>
                <td>
                    <asp:DropDownList ID="ddIloscStron" runat="server">
                        <asp:ListItem>&lt;</asp:ListItem>
                        <asp:ListItem>=</asp:ListItem>
                        <asp:ListItem>&gt;</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="txtIloscStron" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="IloscStronRegularExpressionValidator" runat="server" ControlToValidate="txtIloscStron" ErrorMessage="Pole musi być liczbą 1-99999" ForeColor="Red" ValidationExpression="^[\d]{1,5}$" ValidationGroup="zaawansowaneGroup"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">ISBN:<br />
                    <asp:Label runat="server" Text="(pomija poprzednie pola)" Font-Size="Small"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtISBN" runat="server" Width="255px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="ISBNRegularExpressionValidator" runat="server" ControlToValidate="txtISBN" ErrorMessage="Numer ISBN musi skłądać się z cyfr i/lub znaków &quot;-&quot;" ForeColor="Red" ValidationExpression="^[\d-]+$" ValidationGroup="zaawansowaneGroup"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnSzukanieZaawansowane" runat="server" Text="Szukaj" OnClick="btnSzukanieZaawansowane_Click" ValidationGroup="zaawansowaneGroup" />
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style1 {
            width: 182px;
        }
        .auto-style2 {
            width: 182px;
            height: 26px;
        }
        .auto-style3 {
            height: 26px;
        width: 479px;
    }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>

