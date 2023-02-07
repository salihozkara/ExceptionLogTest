using System.Threading.Tasks;

namespace LogTest.Data;

public interface ILogTestDbSchemaMigrator
{
    Task MigrateAsync();
}
