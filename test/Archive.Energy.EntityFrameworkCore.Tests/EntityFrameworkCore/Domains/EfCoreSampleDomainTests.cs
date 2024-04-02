using Archive.Energy.Samples;
using Xunit;

namespace Archive.Energy.EntityFrameworkCore.Domains;

[Collection(EnergyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EnergyEntityFrameworkCoreTestModule>
{

}
