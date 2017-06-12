<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ACP.aspx.cs" Inherits="Projekt.MS3.ACP" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick" Enabled="False">
    </asp:Timer>

    <div id="access_denied" runat="server" style="text-align: center">
        <asp:Label ID="LabelError" runat="server" Text="Brak dostępu!" ForeColor="Red"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Wróć do strony głównej...</asp:HyperLink>&nbsp;<asp:Label ID="LabelTime" runat="server">3</asp:Label>
    </div>

    <div id="info" runat="server" visible="false" style="padding: 5px; margin: 3px; background-color: #CCFFCC; text-align: center;">
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>

    <div id="access_granted" runat="server">
        <div style="text-align: right">
            [<asp:LinkButton ID="LinkButtonAddBook" runat="server" PostBackUrl="~/Add.aspx">Dodaj książkę</asp:LinkButton>]
        </div>
        <div style="">
            <asp:Button ID="btnZaznaczWszystko" runat="server" Text="Zaznacz wszystko" OnClick="btnZaznaczWszystko_Click" />
            <asp:Button ID="btnUsunZaznaczone" runat="server" Text="Usuń zaznaczone" OnClick="btnUsunZaznaczone_Click" />
            Liczba elementów na stronę:        
                    <asp:DropDownList ID="ddElementowNaStrone" runat="server" OnSelectedIndexChanged="ddElementowNaStrone_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem Selected="True">50</asp:ListItem>
                        <asp:ListItem>100</asp:ListItem>
                        <asp:ListItem>200</asp:ListItem>
                        <asp:ListItem>500</asp:ListItem>
                        <asp:ListItem>1000</asp:ListItem>
                    </asp:DropDownList>
        </div>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
            <EmptyDataTemplate>
                No data was returned.
            </EmptyDataTemplate>
            <ItemSeparatorTemplate>
                <br />
            </ItemSeparatorTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="CheckBoxItem" runat="server" />
                <asp:HiddenField ID="ID_KSIAZKA" runat="server" Value='<%# Eval("Id") %>' />
                <asp:HyperLink runat="server" NavigateUrl='<%# Eval("Id", "~/Show.aspx?id={0}") %>' ForeColor="Black"><%# Eval("tytul") %></asp:HyperLink>
                [<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl='<%# string.Format("~/Add.aspx?editID={0}", Eval("Id")) %>'>Edytuj</asp:LinkButton>]
            </ItemTemplate>
            <LayoutTemplate>
                <ul id="itemPlaceholderContainer" runat="server" style="">
                    <li runat="server" id="itemPlaceholder" />
                </ul>
            </LayoutTemplate>
        </asp:ListView>
        <asp:DataPager ID="DataPager1" runat="server" PageSize="50" PagedControlID="ListView1">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" FirstPageText="Pierwsza" LastPageText="Ostatnia" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" FirstPageText="Pierwsza" LastPageText="Ostatnia" />
            </Fields>
        </asp:DataPager>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getBooksList" TypeName="Projekt.MS3.ACP"></asp:ObjectDataSource>
    </div>
</asp:Content>
