using AbpVnextDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpVnextDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpVnextDemoPageModel : AbpPageModel
    {
        protected AbpVnextDemoPageModel()
        {
            LocalizationResourceType = typeof(AbpVnextDemoResource);
        }
    }
}