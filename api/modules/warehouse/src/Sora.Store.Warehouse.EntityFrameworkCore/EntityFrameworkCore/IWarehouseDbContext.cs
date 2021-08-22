using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Sora.Store.Warehouse.EntityFrameworkCore
{
    [ConnectionStringName(WarehouseDbProperties.ConnectionStringName)]
    public interface IWarehouseDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}