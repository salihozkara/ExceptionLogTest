using LogTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LogTest.Web.Pages;

public abstract class LogTestPageModel : AbpPageModel
{
    protected LogTestPageModel()
    {
        LocalizationResourceType = typeof(LogTestResource);
    }
}
