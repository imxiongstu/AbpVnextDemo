using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpVnextDemo.EntityFrameworkCore
{
    /*EF Core控制台命令需要这个类(像添加-迁移和更新-数据库命令)*/
    public class AbpVnextDemoDbContextFactory : IDesignTimeDbContextFactory<AbpVnextDemoDbContext>
    {
        public AbpVnextDemoDbContext CreateDbContext(string[] args)
        {
            AbpVnextDemoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpVnextDemoDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), ServerVersion.Parse("5.7"));

            return new AbpVnextDemoDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpVnextDemo.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
