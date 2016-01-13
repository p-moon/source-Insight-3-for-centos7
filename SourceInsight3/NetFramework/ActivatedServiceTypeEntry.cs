public class ActivatedServiceTypeEntry : TypeEntry
{

	// Constructors
	public ActivatedServiceTypeEntry(string typeName, string assemblyName) {}
	public ActivatedServiceTypeEntry(Type type) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type ObjectType { get{} }
	public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get{} set{} }
	public string TypeName { get{} set{} }
	public string AssemblyName { get{} set{} }
}

