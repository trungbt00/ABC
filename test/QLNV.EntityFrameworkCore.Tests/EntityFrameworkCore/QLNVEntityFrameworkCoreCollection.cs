using Xunit;

namespace QLNV.EntityFrameworkCore;

[CollectionDefinition(QLNVTestConsts.CollectionDefinitionName)]
public class QLNVEntityFrameworkCoreCollection : ICollectionFixture<QLNVEntityFrameworkCoreFixture>
{

}
