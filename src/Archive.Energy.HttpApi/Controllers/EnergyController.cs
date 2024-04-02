using Archive.Energy.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Archive.Energy.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EnergyController : AbpControllerBase
{
    protected EnergyController()
    {
        LocalizationResource = typeof(EnergyResource);
    }
}
