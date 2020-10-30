using MongoDB.Driver;
using Mundipagg.Domain.Entities;
using Mundipagg.Domain.Interfaces;

namespace Mundipagg.Infra.Data.Context
{
    public class MundipaggDb
    {
        private readonly IMongoDatabase database;
        private readonly IMundipaggStoreDatabaseSettings _settings;
        public MundipaggDb(IMundipaggStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            database = client.GetDatabase(settings.DatabaseName);
            _settings = settings;
        }

        public IMongoCollection<Produto> Produtos
        {
            get { return database.GetCollection<Produto>(_settings.MundipaggConllectionName); }
        }
    }
}
