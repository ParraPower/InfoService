using System;
using System.Collections.Generic;

namespace InfoServiceDataLayer.Models.Implementations
{
    public partial class User : Interfaces.IUser
    {
        public int Iduser { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Passwordhash { get; set; }
        public string Username { get; set; }
        public sbyte Status { get; set; }
        public DateTime Datecreatedutc { get; set; }
        public DateTime Datemodifiedutc { get; set; }
    }
}
