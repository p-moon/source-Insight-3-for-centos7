public class Roles
{

	// Methods
	public static bool IsUserInRole(string username, string roleName) {}
	public static bool IsUserInRole(string roleName) {}
	public static string[] GetRolesForUser(string username) {}
	public static string[] GetRolesForUser() {}
	public static string[] GetUsersInRole(string roleName) {}
	public static void CreateRole(string roleName) {}
	public static bool DeleteRole(string roleName, bool throwOnPopulatedRole) {}
	public static bool DeleteRole(string roleName) {}
	public static bool RoleExists(string roleName) {}
	public static void AddUserToRole(string username, string roleName) {}
	public static void AddUserToRoles(string username, string[] roleNames) {}
	public static void AddUsersToRole(string[] usernames, string roleName) {}
	public static void AddUsersToRoles(string[] usernames, string[] roleNames) {}
	public static void RemoveUserFromRole(string username, string roleName) {}
	public static void RemoveUserFromRoles(string username, string[] roleNames) {}
	public static void RemoveUsersFromRole(string[] usernames, string roleName) {}
	public static void RemoveUsersFromRoles(string[] usernames, string[] roleNames) {}
	public static string[] GetAllRoles() {}
	public static void DeleteCookie() {}
	public static string[] FindUsersInRole(string roleName, string usernameToMatch) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RoleProvider Provider { get{} }
	public RoleProviderCollection Providers { get{} }
	public string CookieName { get{} }
	public bool CacheRolesInCookie { get{} }
	public int CookieTimeout { get{} }
	public string CookiePath { get{} }
	public bool CookieRequireSSL { get{} }
	public bool CookieSlidingExpiration { get{} }
	public CookieProtection CookieProtectionValue { get{} }
	public bool CreatePersistentCookie { get{} }
	public string Domain { get{} }
	public int MaxCachedResults { get{} }
	public bool Enabled { get{} }
	public string ApplicationName { get{} set{} }
}

