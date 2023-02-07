using LogTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LogTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LogTestController : AbpControllerBase
{
    protected LogTestController()
    {
        LocalizationResource = typeof(LogTestResource);
    }
}
