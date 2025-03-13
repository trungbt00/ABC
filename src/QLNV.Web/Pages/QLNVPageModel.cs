using QLNV.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace QLNV.Web.Pages;

public abstract class QLNVPageModel : AbpPageModel
{
    protected QLNVPageModel()
    {
        LocalizationResourceType = typeof(QLNVResource);
    }
}
