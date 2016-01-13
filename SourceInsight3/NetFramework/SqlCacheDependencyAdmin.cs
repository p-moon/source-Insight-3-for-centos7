public class SqlCacheDependencyAdmin
{

	// Methods
	public static void EnableNotifications(string connectionString) {}
	public static void DisableNotifications(string connectionString) {}
	public static void EnableTableForNotifications(string connectionString, string table) {}
	public static void EnableTableForNotifications(string connectionString, string[] tables) {}
	public static void DisableTableForNotifications(string connectionString, string table) {}
	public static void DisableTableForNotifications(string connectionString, string[] tables) {}
	public static string[] GetTablesEnabledForNotifications(string connectionString) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

