using Volo.Abp.Reflection;

namespace Sora.Store.Warehouse.Permissions
{
    public class WarehousePermissions
    {
        public const string GroupName = "Warehouse";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(WarehousePermissions));
        }
    }
}