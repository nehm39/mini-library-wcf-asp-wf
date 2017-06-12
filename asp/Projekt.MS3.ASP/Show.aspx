<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Projekt.MS3.Show" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <div id="edit" runat="server" style="float:right" visible="false">
        [<asp:LinkButton ID="lbtnEdytuj" runat="server" OnClick="lbtnEdytuj_Click">Edytuj</asp:LinkButton>]
        [<asp:LinkButton ID="lbtnUsun" runat="server" OnClick="lbtnUsun_Click">Usuń</asp:LinkButton>]
    </div>
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="LabelTytul" runat="server" Text=" XML. Szybki startWydanie II" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="ImageOkladka" runat="server" ImageAlign="Left" ImageUrl="~/covers/xml-szybki-start,pd,472906.jpg" Height="200" Width="140" Style="margin-right: 10px" />
                <asp:Label ID="LabelOpis" runat="server" Text="Przewodnik po świecie XML!  XML to uniwersalny tekstowy format prezentacji danych. Jasne zasady tworzenia dokumentów XML oraz prostota ich wykorzystania sprawiły, że stał się standardem wymiany danych. Format XML można zastosować na setki sposobów: serializacja obiektów czy komunikacja z webserwisami to najprostsze z nich. Żeby stworzyć swój pierwszy dokument XML, nie potrzebujesz żadnych specjalistycznych narzędzi. Wystarczy notatnik, ta książka i możesz poznawać świat formatu XML!  W trakcie lektury zapoznasz się z zasadami tworzenia dokumentów XML. Nauczysz się zagnieżdżać elementy, dodawać atrybuty, stosować puste elementy oraz komentować tworzony dokument. W kolejnych rozdziałach poznasz prawdziwą potęgę formatu XML - transformacje za pomocą XSLT. Dzięki nim będziesz w stanie przekształcić dokument źródłowy w dowolnie skonstruowany dokument docelowy. Ponadto przekonasz się, do czego mogą być przydatne dokumenty DTD, które opisują format pliku XML. Na koniec będziesz miał okazję poznać najnowsze zalecenia W3C w zakresie XML oraz wiele praktycznych zastosowań tego formatu. Ta książka jest kompendium wiedzy na temat najistotniejszych zagadnień związanych z formatem XML. Warto mieć ją zawsze pod ręką!  Dzięki tej książce:  poznasz zasady tworzenia dokumentów XML wykorzystasz XSLT do transformacji XML sprawdzisz poprawność dokumentu dzięki DTD poznasz praktyczne zastosowania formatu XML  Wykorzystaj możliwości formatu XML!"></asp:Label></td>
        </tr>
    </table>
    <br />
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Autorzy:" Font-Bold="True"></asp:Label></td>
            <td>
                <asp:Label ID="LabelAutorzy" runat="server" Text="A. Bolek, D. Lolek"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Wydawnictwo:" Font-Bold="True"></asp:Label></td>
            <td>
                <asp:Label ID="LabelWydawnictwo" runat="server" Text="Helion"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Oprawa:"></asp:Label></td>
            <td>
                <asp:Label ID="LabelOprawa" runat="server" Text="miękka"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Wymiary:"></asp:Label></td>
            <td>
                <asp:Label ID="LabelWymiary" runat="server" Text="170x230"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Ilość stron:"></asp:Label></td>
            <td>
                <asp:Label ID="LabelLiczbaStron" runat="server" Text="296"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="ISBN:"></asp:Label></td>
            <td>
                <asp:Label ID="LabelISBN" runat="server" Text="978-83-246-8237-9"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
