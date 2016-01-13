public class WindowsTokenRoleProvider : RoleProvider
{

	// Constructors
	public WindowsTokenRoleProvider() {}

	// Methods
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public bool IsUserInRole(string username, System.Security.Principal.WindowsBuiltInRole role) {}
	public virtual bool IsUserInRole(string username, string roleName) {}
	public virtual string[] GetRolesForUser(string username) {}
	public virtual void CreateRole(string roleName) {}
	public virtual bool DeleteRole(string roleName, bool throwOnPopulatedRole) {}
	public virtual bool RoleExists(string roleName) {}
	public virtual void AddUsersToRoles(string[] usernames, string[] roleNames) {}
	public virtual void RemoveUsersFromRoles(string[] usernames, string[] roleNames) {}
	public virtual string[] GetUsersInRole(string roleName) {}
	public virtual string[] GetAllRoles() {}
	public virtual string[] FindUsersInRole(string roleName, string usernameToMatch) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

