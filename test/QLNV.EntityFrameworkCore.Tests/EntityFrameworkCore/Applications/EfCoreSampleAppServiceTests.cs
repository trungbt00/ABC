using QLNV.Samples;
using Xunit;

namespace QLNV.EntityFrameworkCore.Applications;

[Collection(QLNVTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<QLNVEntityFrameworkCoreTestModule>
{

}
