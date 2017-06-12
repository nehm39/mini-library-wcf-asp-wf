<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projekt.MS3.Default" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getBooksList" TypeName="Projekt.MS3.Default"></asp:ObjectDataSource>
    <div style="margin-left: 10%; margin-right: 10%">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" OnItemDataBound="ListView1_ItemDataBound">
            <AlternatingItemTemplate>
                <tr>
                    <td>
                        <asp:Panel runat="server" Style="background-color: #FFF8DC;">
                            <asp:HyperLink ID="K_TYTULLabel" runat="server" NavigateUrl='<%# Eval("Id", "~/Show.aspx?id={0}") %>' Font-Bold="True"><%# Eval("tytul") %></asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="K_OKLADKAImage" runat="server" ImageUrl='<%# Eval("okladka") %>' NavigateUrl='<%# Eval("Id", "~/Show.aspx?id={0}") %>' CssClass="ImageTextFlow" ImageHeight="200" ImageWidth="140" />
                            <asp:Label ID="K_OPISLabel" runat="server" Text='<%# Eval("opis") %>' />
                            <br />
                        </asp:Panel>
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EmptyDataTemplate>
                <span>No data was returned.</span>
            </EmptyDataTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Panel runat="server" Style="background-color: #DCDCDC; color: #000000;">
                            <asp:HyperLink ID="K_TYTULLabel" runat="server" NavigateUrl='<%# Eval("Id", "~/Show.aspx?id={0}") %>' Font-Bold="True"><%# Eval("tytul") %></asp:HyperLink>
                            <br />
                            <br />
                            <asp:HyperLink ID="K_OKLADKAImage" runat="server" ImageUrl='<%# Eval("okladka") %>' NavigateUrl='<%# Eval("Id", "~/Show.aspx?id={0}") %>' CssClass="ImageTextFlow" ImageHeight="200" ImageWidth="140"/>
                            <asp:Label ID="K_OPISLabel" runat="server" Text='<%# Eval("opis") %>' />
                            <br />
                        </asp:Panel>
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <div id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                    <table id="testowanie">
                        <span runat="server" id="itemPlaceholder" />
                    </table>
                </div>
                <div style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                    <asp:DataPager ID="DataPager1" runat="server">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" NextPageText="Następna" PreviousPageText="Poprzednia" LastPageText="Ostatnia" FirstPageText="Pierwsza" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </LayoutTemplate>
        </asp:ListView>
    </div>
</asp:Content>
