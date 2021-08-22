namespace Sora.Store.Warehouse
{
    public static class WarehouseDbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Default";
    }
}
