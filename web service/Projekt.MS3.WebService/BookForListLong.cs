﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Projekt.MS3.WebService
{
    [DataContract]
    public class BookForListLong
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String tytul { get; set; }

        [DataMember]
        public String opis { get; set; }

        [DataMember]
        public String okladka { get; set; }
    }
}