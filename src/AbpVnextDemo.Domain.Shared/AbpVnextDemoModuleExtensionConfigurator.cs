using System.ComponentModel.DataAnnotations;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace AbpVnextDemo
{
    public static class AbpVnextDemoModuleExtensionConfigurator
    {
        private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

        public static void Configure()
        {
            OneTimeRunner.Run(() =>
            {
                ConfigureExistingProperties();
                ConfigureExtraProperties();
            });
        }

        private static void ConfigureExistingProperties()
        {
            /* 您可以更改应用程序使用的模块中定义的实体属性的最大长度。
             *
             * Example: Change user and role name max lengths

               IdentityUserConsts.MaxNameLength = 99;
               IdentityRoleConsts.MaxNameLength = 99;

             * 注意:不建议修改属性长度
             * 除非你真的需要它。尽可能使用标准值。
             *
             * 如果您正在使用EF Core，您将需要在更改之后运行add-migration命令。
             */
        }

        private static void ConfigureExtraProperties()
        {
            /* 您可以为应用程序使用的模块中定义的实体配置额外属性。
             *
             * 这个类可以用高级的、易于使用的API来定义这些额外的属性。
             *
             * Example: 向标识模块的用户实体添加一个新属性

               ObjectExtensionManager.Instance.Modules()
                  .ConfigureIdentity(identity =>
                  {
                      identity.ConfigureUser(user =>
                      {
                          user.AddOrUpdateProperty<string>( //property type: string
                              "SocialSecurityNumber", //property name
                              property =>
                              {
                                  //validation rules
                                  property.Attributes.Add(new RequiredAttribute());
                                  property.Attributes.Add(new StringLengthAttribute(64) {MinimumLength = 4});

                                  //...other configurations for this property
                              }
                          );
                      });
                  });

             * See the documentation for more:
             * https://docs.abp.io/en/abp/latest/Module-Entity-Extensions
             */
        }
    }
}
