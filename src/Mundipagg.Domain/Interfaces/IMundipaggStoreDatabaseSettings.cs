using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Domain.Interfaces
{
    public interface IMundipaggStoreDatabaseSettings
    {
        string MundipaggConllectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
