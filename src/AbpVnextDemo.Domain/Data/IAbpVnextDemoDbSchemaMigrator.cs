using System.Threading.Tasks;

namespace AbpVnextDemo.Data
{
    public interface IAbpVnextDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
