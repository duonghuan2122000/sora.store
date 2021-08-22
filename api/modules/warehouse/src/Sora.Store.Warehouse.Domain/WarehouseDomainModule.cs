using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Sora.Store.Warehouse
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(WarehouseDomainSharedModule)
    )]
    public class WarehouseDomainModule : AbpModule
    {

    }
}
