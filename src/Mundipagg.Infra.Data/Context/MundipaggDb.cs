using MongoDB.Driver;
using Mundipagg.Domain.Entities;
using Mundipagg.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mundipagg.Infra.Data.Context
{
    public class MundipaggDb
    {
        private readonly IMongoDatabase database;
        public MundipaggDb(IMundipaggStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
             database = client.GetDatabase(settings.DatabaseName);
   
        }

        public IMongoCollection<Produto> Produtos
        {
            get { return database.GetCollection<Produto>("Produtos"); }
        }
    }
}
