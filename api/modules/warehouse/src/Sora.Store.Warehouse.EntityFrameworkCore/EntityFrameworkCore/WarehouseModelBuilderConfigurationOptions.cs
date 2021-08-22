using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Sora.Store.Warehouse.EntityFrameworkCore
{
    public class WarehouseModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public WarehouseModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}