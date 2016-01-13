public class AuthorizationRule : System.Configuration.ConfigurationElement
{

	// Constructors
	public AuthorizationRule(AuthorizationRuleAction action) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsReadOnly() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public AuthorizationRuleAction Action { get{} set{} }
	public System.Collections.Specialized.StringCollection Verbs { get{} }
	public System.Collections.Specialized.StringCollection Users { get{} }
	public System.Collections.Specialized.StringCollection Roles { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

