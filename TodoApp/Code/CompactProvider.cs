using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServerCompact;
using System.Linq;
using System.Web;

namespace TodoApp.Code
{
    public class CompactProvider : DbConfiguration
    {
        public CompactProvider()
        {
            SetProviderServices(
                SqlCeProviderServices.ProviderInvariantName,
                SqlCeProviderServices.Instance);
        }
    }
}