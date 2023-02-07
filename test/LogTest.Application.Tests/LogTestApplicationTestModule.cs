using Volo.Abp.Modularity;

namespace LogTest;

[DependsOn(
    typeof(LogTestApplicationModule),
    typeof(LogTestDomainTestModule)
    )]
public class LogTestApplicationTestModule : AbpModule
{

}
