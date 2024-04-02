using Xunit;

namespace Archive.Energy.EntityFrameworkCore;

[CollectionDefinition(EnergyTestConsts.CollectionDefinitionName)]
public class EnergyEntityFrameworkCoreCollection : ICollectionFixture<EnergyEntityFrameworkCoreFixture>
{

}
