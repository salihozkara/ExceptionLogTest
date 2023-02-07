using LogTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LogTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LogTestEntityFrameworkCoreModule),
    typeof(LogTestApplicationContractsModule)
)]
public class LogTestDbMigratorModule : AbpModule
{

}
