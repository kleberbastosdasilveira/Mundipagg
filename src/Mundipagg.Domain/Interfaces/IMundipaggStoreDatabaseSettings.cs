namespace Mundipagg.Domain.Interfaces
{
    public interface IMundipaggStoreDatabaseSettings
    {
        string MundipaggConllectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
