using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LogTest.Web;

[Dependency(ReplaceServices = true)]
public class LogTestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LogTest";
}
