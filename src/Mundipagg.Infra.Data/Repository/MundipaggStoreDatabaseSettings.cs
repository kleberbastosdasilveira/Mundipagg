﻿using Mundipagg.Domain.Interfaces;

namespace Mundipagg.Infra.Data.Repository
{
    public class MundipaggStoreDatabaseSettings : IMundipaggStoreDatabaseSettings
    {
        public string MundipaggConllectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
