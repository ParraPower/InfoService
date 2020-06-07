using System;
using System.Collections.Generic;

namespace InfoServiceDataLayer.Models.Implementations
{
    public partial class Clientapp : Interfaces.IClientapp
    {
        public int Idclientapp { get; set; }
        public string Name { get; set; }
        public string Secrethash { get; set; }
        public bool Status { get; set; }
        public DateTime Datecreatedutc { get; set; }
        public DateTime Datemodifiedutc { get; set; }
    }
}
