using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LogTest.Data;

/* This is used if database provider does't define
 * ILogTestDbSchemaMigrator implementation.
 */
public class NullLogTestDbSchemaMigrator : ILogTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
