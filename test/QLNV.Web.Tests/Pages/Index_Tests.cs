using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace QLNV.Pages;

[Collection(QLNVTestConsts.CollectionDefinitionName)]
public class Index_Tests : QLNVWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
