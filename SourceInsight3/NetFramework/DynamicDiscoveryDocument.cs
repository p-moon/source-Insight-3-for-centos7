public class DynamicDiscoveryDocument
{

	// Constructors
	public DynamicDiscoveryDocument() {}

	// Methods
	public void Write(System.IO.Stream stream) {}
	public static DynamicDiscoveryDocument Load(System.IO.Stream stream) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;

	// Properties
	public ExcludePathInfo[] ExcludePaths { get{} set{} }
}

