public class ActivatedClientTypeEntry : TypeEntry
{

	// Constructors
	public ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl) {}
	public ActivatedClientTypeEntry(Type type, string appUrl) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationUrl { get{} }
	public Type ObjectType { get{} }
	public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get{} set{} }
	public string TypeName { get{} set{} }
	public string AssemblyName { get{} set{} }
}

