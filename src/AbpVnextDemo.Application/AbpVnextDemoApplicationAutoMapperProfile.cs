using AutoMapper;

namespace AbpVnextDemo
{
    public class AbpVnextDemoApplicationAutoMapperProfile : Profile
    {
        public AbpVnextDemoApplicationAutoMapperProfile()
        {
            /* 你可以在这里统一的管理你的Dto映射类。
             * 也可以分裂管理你的Dto映射类，只要继承了Profile，就会被自动注入 */
        }
    }
}
