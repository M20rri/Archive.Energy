using System;
using System.Collections.Generic;
using System.Text;
using Archive.Energy.Localization;
using Volo.Abp.Application.Services;

namespace Archive.Energy;

/* Inherit your application services from this class.
 */
public abstract class EnergyAppService : ApplicationService
{
    protected EnergyAppService()
    {
        LocalizationResource = typeof(EnergyResource);
    }
}
