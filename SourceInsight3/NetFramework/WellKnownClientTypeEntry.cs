public class WellKnownClientTypeEntry : TypeEntry
{

	// Constructors
	public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl) {}
	public WellKnownClientTypeEntry(Type type, string objectUrl) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ObjectUrl { get{} }
	public Type ObjectType { get{} }
	public string ApplicationUrl { get{} set{} }
	public string TypeName { get{} set{} }
	public string AssemblyName { get{} set{} }
}

