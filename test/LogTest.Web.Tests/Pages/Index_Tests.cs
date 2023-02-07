using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LogTest.Pages;

public class Index_Tests : LogTestWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
