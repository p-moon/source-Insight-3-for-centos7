public class DesignerDataConnection
{

	// Constructors
	public DesignerDataConnection(string name, string providerName, string connectionString) {}
	public DesignerDataConnection(string name, string providerName, string connectionString, bool isConfigured) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ConnectionString { get{} }
	public bool IsConfigured { get{} }
	public string Name { get{} }
	public string ProviderName { get{} }
}

