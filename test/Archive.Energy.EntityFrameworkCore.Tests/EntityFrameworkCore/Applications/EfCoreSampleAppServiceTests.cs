using Archive.Energy.Samples;
using Xunit;

namespace Archive.Energy.EntityFrameworkCore.Applications;

[Collection(EnergyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EnergyEntityFrameworkCoreTestModule>
{

}
