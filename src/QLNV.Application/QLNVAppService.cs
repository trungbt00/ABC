using QLNV.Localization;
using Volo.Abp.Application.Services;

namespace QLNV;

/* Inherit your application services from this class.
 */
public abstract class QLNVAppService : ApplicationService
{
    protected QLNVAppService()
    {
        LocalizationResource = typeof(QLNVResource);
    }
}
