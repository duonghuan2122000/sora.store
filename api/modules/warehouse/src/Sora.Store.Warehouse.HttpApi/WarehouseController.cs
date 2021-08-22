using Sora.Store.Warehouse.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sora.Store.Warehouse
{
    public abstract class WarehouseController : AbpController
    {
        protected WarehouseController()
        {
            LocalizationResource = typeof(WarehouseResource);
        }
    }
}
