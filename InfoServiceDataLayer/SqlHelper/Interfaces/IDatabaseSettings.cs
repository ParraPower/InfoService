using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace InfoServiceDataLayer.SqlHelper.Interfaces
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
    }
}
