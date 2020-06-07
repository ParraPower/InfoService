using InfoServiceDataLayer.SqlHelper.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoServiceDataLayer.SqlHelper.Implementations
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
    }
}
