public class RoleProvider : System.Configuration.Provider.ProviderBase
{

	// Methods
	public abstract virtual bool IsUserInRole(string username, string roleName) {}
	public abstract virtual string[] GetRolesForUser(string username) {}
	public abstract virtual void CreateRole(string roleName) {}
	public abstract virtual bool DeleteRole(string roleName, bool throwOnPopulatedRole) {}
	public abstract virtual bool RoleExists(string roleName) {}
	public abstract virtual void AddUsersToRoles(string[] usernames, string[] roleNames) {}
	public abstract virtual void RemoveUsersFromRoles(string[] usernames, string[] roleNames) {}
	public abstract virtual string[] GetUsersInRole(string roleName) {}
	public abstract virtual string[] GetAllRoles() {}
	public abstract virtual string[] FindUsersInRole(string roleName, string usernameToMatch) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string Name { get{} }
	public string Description { get{} }
}

