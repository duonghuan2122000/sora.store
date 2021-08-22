using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Sora.Store.Warehouse
{
    [DependsOn(
        typeof(WarehouseDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class WarehouseApplicationContractsModule : AbpModule
    {

    }
}
