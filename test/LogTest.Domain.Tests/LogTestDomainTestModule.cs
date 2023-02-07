using LogTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LogTest;

[DependsOn(
    typeof(LogTestEntityFrameworkCoreTestModule)
    )]
public class LogTestDomainTestModule : AbpModule
{

}
