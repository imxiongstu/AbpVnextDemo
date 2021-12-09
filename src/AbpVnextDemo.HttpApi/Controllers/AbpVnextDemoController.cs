using AbpVnextDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpVnextDemo.Controllers
{
    /* 从这个类继承你的控制器.
     */
    public abstract class AbpVnextDemoController : AbpController
    {
        protected AbpVnextDemoController()
        {
            LocalizationResource = typeof(AbpVnextDemoResource);
        }
    }
}