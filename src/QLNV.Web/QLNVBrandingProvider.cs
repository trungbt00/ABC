using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using QLNV.Localization;

namespace QLNV.Web;

[Dependency(ReplaceServices = true)]
public class QLNVBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<QLNVResource> _localizer;

    public QLNVBrandingProvider(IStringLocalizer<QLNVResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
