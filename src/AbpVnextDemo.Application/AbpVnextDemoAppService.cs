using System;
using System.Collections.Generic;
using System.Text;
using AbpVnextDemo.Localization;
using Volo.Abp.Application.Services;

namespace AbpVnextDemo
{
    /* 从这个类继承应用程序服务。
     */
    public abstract class AbpVnextDemoAppService : ApplicationService
    {
        protected AbpVnextDemoAppService()
        {
            LocalizationResource = typeof(AbpVnextDemoResource);
        }
    }
}
