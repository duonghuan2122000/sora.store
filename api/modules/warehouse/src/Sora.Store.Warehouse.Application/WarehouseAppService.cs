using Sora.Store.Warehouse.Localization;
using Volo.Abp.Application.Services;

namespace Sora.Store.Warehouse
{
    public abstract class WarehouseAppService : ApplicationService
    {
        protected WarehouseAppService()
        {
            LocalizationResource = typeof(WarehouseResource);
            ObjectMapperContext = typeof(WarehouseApplicationModule);
        }
    }
}
