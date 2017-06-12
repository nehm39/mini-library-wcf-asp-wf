using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Projekt.MS3.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILibraryService
    {

        [OperationContract]
        Book getBookInfo(int id);

        [OperationContract]
		[WebInvoke]
        List<BookForListShort> getBooksListShort();

        [OperationContract]
        List<BookForListLong> getBooksListLong();

        [OperationContract]
        Boolean deleteBook(int id);

        [OperationContract]
        Boolean checkCredentials(String login, String password);

        [OperationContract]
        Boolean addBook(Book book);

        [OperationContract]
        Boolean updateBook(Book book);

        [OperationContract]
        List<BookForListShort> searchBooksSimple(String text);

        [OperationContract]
        List<BookForListShort> searchBooksAdvanced(String query, Boolean titleDesc, String authors, String publisher, int binding, int pages, int pagesSearchType, String isbn);

        // TODO: Add your service operations here
    }

}
