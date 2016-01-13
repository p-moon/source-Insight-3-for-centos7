public class HttpHandlerAction : System.Configuration.ConfigurationElement
{

	// Constructors
	public HttpHandlerAction(string path, string type, string verb) {}
	public HttpHandlerAction(string path, string type, string verb, bool validate) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Path { get{} set{} }
	public string Verb { get{} set{} }
	public string Type { get{} set{} }
	public bool Validate { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

