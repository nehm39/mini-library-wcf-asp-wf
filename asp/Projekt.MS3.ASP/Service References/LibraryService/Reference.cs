﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt.MS3.LibraryService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/Projekt.MS3.WebService")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string autorzyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iloscStronField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string isbnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string okladkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string opisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string oprawaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tytulField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string wydawnictwoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string wymiaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string autorzy {
            get {
                return this.autorzyField;
            }
            set {
                if ((object.ReferenceEquals(this.autorzyField, value) != true)) {
                    this.autorzyField = value;
                    this.RaisePropertyChanged("autorzy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int iloscStron {
            get {
                return this.iloscStronField;
            }
            set {
                if ((this.iloscStronField.Equals(value) != true)) {
                    this.iloscStronField = value;
                    this.RaisePropertyChanged("iloscStron");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string isbn {
            get {
                return this.isbnField;
            }
            set {
                if ((object.ReferenceEquals(this.isbnField, value) != true)) {
                    this.isbnField = value;
                    this.RaisePropertyChanged("isbn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string okladka {
            get {
                return this.okladkaField;
            }
            set {
                if ((object.ReferenceEquals(this.okladkaField, value) != true)) {
                    this.okladkaField = value;
                    this.RaisePropertyChanged("okladka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string opis {
            get {
                return this.opisField;
            }
            set {
                if ((object.ReferenceEquals(this.opisField, value) != true)) {
                    this.opisField = value;
                    this.RaisePropertyChanged("opis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string oprawa {
            get {
                return this.oprawaField;
            }
            set {
                if ((object.ReferenceEquals(this.oprawaField, value) != true)) {
                    this.oprawaField = value;
                    this.RaisePropertyChanged("oprawa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tytul {
            get {
                return this.tytulField;
            }
            set {
                if ((object.ReferenceEquals(this.tytulField, value) != true)) {
                    this.tytulField = value;
                    this.RaisePropertyChanged("tytul");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string wydawnictwo {
            get {
                return this.wydawnictwoField;
            }
            set {
                if ((object.ReferenceEquals(this.wydawnictwoField, value) != true)) {
                    this.wydawnictwoField = value;
                    this.RaisePropertyChanged("wydawnictwo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string wymiary {
            get {
                return this.wymiaryField;
            }
            set {
                if ((object.ReferenceEquals(this.wymiaryField, value) != true)) {
                    this.wymiaryField = value;
                    this.RaisePropertyChanged("wymiary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookForListShort", Namespace="http://schemas.datacontract.org/2004/07/Projekt.MS3.WebService")]
    [System.SerializableAttribute()]
    public partial class BookForListShort : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tytulField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tytul {
            get {
                return this.tytulField;
            }
            set {
                if ((object.ReferenceEquals(this.tytulField, value) != true)) {
                    this.tytulField = value;
                    this.RaisePropertyChanged("tytul");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookForListLong", Namespace="http://schemas.datacontract.org/2004/07/Projekt.MS3.WebService")]
    [System.SerializableAttribute()]
    public partial class BookForListLong : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string okladkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string opisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tytulField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string okladka {
            get {
                return this.okladkaField;
            }
            set {
                if ((object.ReferenceEquals(this.okladkaField, value) != true)) {
                    this.okladkaField = value;
                    this.RaisePropertyChanged("okladka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string opis {
            get {
                return this.opisField;
            }
            set {
                if ((object.ReferenceEquals(this.opisField, value) != true)) {
                    this.opisField = value;
                    this.RaisePropertyChanged("opis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tytul {
            get {
                return this.tytulField;
            }
            set {
                if ((object.ReferenceEquals(this.tytulField, value) != true)) {
                    this.tytulField = value;
                    this.RaisePropertyChanged("tytul");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryService.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBookInfo", ReplyAction="http://tempuri.org/ILibraryService/getBookInfoResponse")]
        Projekt.MS3.LibraryService.Book getBookInfo(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBookInfo", ReplyAction="http://tempuri.org/ILibraryService/getBookInfoResponse")]
        System.Threading.Tasks.Task<Projekt.MS3.LibraryService.Book> getBookInfoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBooksListShort", ReplyAction="http://tempuri.org/ILibraryService/getBooksListShortResponse")]
        Projekt.MS3.LibraryService.BookForListShort[] getBooksListShort();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBooksListShort", ReplyAction="http://tempuri.org/ILibraryService/getBooksListShortResponse")]
        System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListShort[]> getBooksListShortAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBooksListLong", ReplyAction="http://tempuri.org/ILibraryService/getBooksListLongResponse")]
        Projekt.MS3.LibraryService.BookForListLong[] getBooksListLong();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/getBooksListLong", ReplyAction="http://tempuri.org/ILibraryService/getBooksListLongResponse")]
        System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListLong[]> getBooksListLongAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/deleteBook", ReplyAction="http://tempuri.org/ILibraryService/deleteBookResponse")]
        bool deleteBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/deleteBook", ReplyAction="http://tempuri.org/ILibraryService/deleteBookResponse")]
        System.Threading.Tasks.Task<bool> deleteBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/checkCredentials", ReplyAction="http://tempuri.org/ILibraryService/checkCredentialsResponse")]
        bool checkCredentials(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/checkCredentials", ReplyAction="http://tempuri.org/ILibraryService/checkCredentialsResponse")]
        System.Threading.Tasks.Task<bool> checkCredentialsAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/addBook", ReplyAction="http://tempuri.org/ILibraryService/addBookResponse")]
        bool addBook(Projekt.MS3.LibraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/addBook", ReplyAction="http://tempuri.org/ILibraryService/addBookResponse")]
        System.Threading.Tasks.Task<bool> addBookAsync(Projekt.MS3.LibraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/updateBook", ReplyAction="http://tempuri.org/ILibraryService/updateBookResponse")]
        bool updateBook(Projekt.MS3.LibraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/updateBook", ReplyAction="http://tempuri.org/ILibraryService/updateBookResponse")]
        System.Threading.Tasks.Task<bool> updateBookAsync(Projekt.MS3.LibraryService.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/searchBooksSimple", ReplyAction="http://tempuri.org/ILibraryService/searchBooksSimpleResponse")]
        Projekt.MS3.LibraryService.BookForListShort[] searchBooksSimple(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/searchBooksSimple", ReplyAction="http://tempuri.org/ILibraryService/searchBooksSimpleResponse")]
        System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListShort[]> searchBooksSimpleAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/searchBooksAdvanced", ReplyAction="http://tempuri.org/ILibraryService/searchBooksAdvancedResponse")]
        Projekt.MS3.LibraryService.BookForListShort[] searchBooksAdvanced(string query, bool titleDesc, string authors, string publisher, int binding, int pages, int pagesSearchType, string isbn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/searchBooksAdvanced", ReplyAction="http://tempuri.org/ILibraryService/searchBooksAdvancedResponse")]
        System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListShort[]> searchBooksAdvancedAsync(string query, bool titleDesc, string authors, string publisher, int binding, int pages, int pagesSearchType, string isbn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : global::Projekt.MS3.LibraryService.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<global::Projekt.MS3.LibraryService.ILibraryService>, global::Projekt.MS3.LibraryService.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Projekt.MS3.LibraryService.Book getBookInfo(int id) {
            return base.Channel.getBookInfo(id);
        }
        
        public System.Threading.Tasks.Task<Projekt.MS3.LibraryService.Book> getBookInfoAsync(int id) {
            return base.Channel.getBookInfoAsync(id);
        }
        
        public Projekt.MS3.LibraryService.BookForListShort[] getBooksListShort() {
            return base.Channel.getBooksListShort();
        }
        
        public System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListShort[]> getBooksListShortAsync() {
            return base.Channel.getBooksListShortAsync();
        }
        
        public Projekt.MS3.LibraryService.BookForListLong[] getBooksListLong() {
            return base.Channel.getBooksListLong();
        }
        
        public System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListLong[]> getBooksListLongAsync() {
            return base.Channel.getBooksListLongAsync();
        }
        
        public bool deleteBook(int id) {
            return base.Channel.deleteBook(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteBookAsync(int id) {
            return base.Channel.deleteBookAsync(id);
        }
        
        public bool checkCredentials(string login, string password) {
            return base.Channel.checkCredentials(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> checkCredentialsAsync(string login, string password) {
            return base.Channel.checkCredentialsAsync(login, password);
        }
        
        public bool addBook(Projekt.MS3.LibraryService.Book book) {
            return base.Channel.addBook(book);
        }
        
        public System.Threading.Tasks.Task<bool> addBookAsync(Projekt.MS3.LibraryService.Book book) {
            return base.Channel.addBookAsync(book);
        }
        
        public bool updateBook(Projekt.MS3.LibraryService.Book book) {
            return base.Channel.updateBook(book);
        }
        
        public System.Threading.Tasks.Task<bool> updateBookAsync(Projekt.MS3.LibraryService.Book book) {
            return base.Channel.updateBookAsync(book);
        }
        
        public Projekt.MS3.LibraryService.BookForListShort[] searchBooksSimple(string text) {
            return base.Channel.searchBooksSimple(text);
        }
        
        public System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListShort[]> searchBooksSimpleAsync(string text) {
            return base.Channel.searchBooksSimpleAsync(text);
        }
        
        public Projekt.MS3.LibraryService.BookForListShort[] searchBooksAdvanced(string query, bool titleDesc, string authors, string publisher, int binding, int pages, int pagesSearchType, string isbn) {
            return base.Channel.searchBooksAdvanced(query, titleDesc, authors, publisher, binding, pages, pagesSearchType, isbn);
        }
        
        public System.Threading.Tasks.Task<Projekt.MS3.LibraryService.BookForListShort[]> searchBooksAdvancedAsync(string query, bool titleDesc, string authors, string publisher, int binding, int pages, int pagesSearchType, string isbn) {
            return base.Channel.searchBooksAdvancedAsync(query, titleDesc, authors, publisher, binding, pages, pagesSearchType, isbn);
        }
    }
}