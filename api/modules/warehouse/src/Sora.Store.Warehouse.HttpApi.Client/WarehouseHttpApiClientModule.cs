using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Sora.Store.Warehouse
{
    [DependsOn(
        typeof(WarehouseApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class WarehouseHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Warehouse";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(WarehouseApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
