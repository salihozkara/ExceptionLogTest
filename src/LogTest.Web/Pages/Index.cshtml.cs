using Microsoft.AspNetCore.Mvc;

namespace LogTest.Web.Pages;

public class IndexModel : LogTestPageModel
{
    private SampleAppService _sampleAppService;

    public IndexModel(SampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    public IActionResult OnGet()
    {
        _sampleAppService.DoSomething();
        return Page();
    }
}
