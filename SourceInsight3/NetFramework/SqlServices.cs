public class SqlServices
{

	// Methods
	public static void Install(string server, string user, string password, string database, SqlFeatures features) {}
	public static void Install(string server, string database, SqlFeatures features) {}
	public static void Install(string database, SqlFeatures features, string connectionString) {}
	public static void Uninstall(string server, string user, string password, string database, SqlFeatures features) {}
	public static void Uninstall(string server, string database, SqlFeatures features) {}
	public static void Uninstall(string database, SqlFeatures features, string connectionString) {}
	public static void InstallSessionState(string server, string user, string password, string customDatabase, SessionStateType type) {}
	public static void InstallSessionState(string server, string customDatabase, SessionStateType type) {}
	public static void InstallSessionState(string customDatabase, SessionStateType type, string connectionString) {}
	public static void UninstallSessionState(string server, string user, string password, string customDatabase, SessionStateType type) {}
	public static void UninstallSessionState(string server, string customDatabase, SessionStateType type) {}
	public static void UninstallSessionState(string customDatabase, SessionStateType type, string connectionString) {}
	public static string GenerateSessionStateScripts(bool install, SessionStateType type, string customDatabase) {}
	public static string GenerateApplicationServicesScripts(bool install, SqlFeatures features, string database) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

