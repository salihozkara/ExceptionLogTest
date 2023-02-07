using LogTest.Localization;
using Volo.Abp.Application.Services;

namespace LogTest;

/* Inherit your application services from this class.
 */
public abstract class LogTestAppService : ApplicationService
{
    protected LogTestAppService()
    {
        LocalizationResource = typeof(LogTestResource);
    }
}
