using System;
using System.Collections.Generic;

namespace InfoServiceDataLayer.Models.Interfaces
{
    public interface IClientapp
    {
        public int Idclientapp { get; set; }
        public string Name { get; set; }
        public string Secrethash { get; set; }
        public bool Status { get; set; }
        public DateTime Datecreatedutc { get; set; }
        public DateTime Datemodifiedutc { get; set; }
    }
}
