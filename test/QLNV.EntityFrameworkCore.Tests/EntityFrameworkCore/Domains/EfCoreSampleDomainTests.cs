using QLNV.Samples;
using Xunit;

namespace QLNV.EntityFrameworkCore.Domains;

[Collection(QLNVTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<QLNVEntityFrameworkCoreTestModule>
{

}
