using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Projekt.MS3.WebService
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String tytul { get; set; }

        [DataMember]
        public String opis { get; set; }

        [DataMember]
        public String autorzy { get; set; }

        [DataMember]
        public String wydawnictwo { get; set; }

        [DataMember]
        public String oprawa { get; set; }

        [DataMember]
        public String wymiary { get; set; }

        [DataMember]
        public int iloscStron { get; set; }

        [DataMember]
        public String isbn { get; set; }

        [DataMember]
        public String okladka { get; set; }
    }
}