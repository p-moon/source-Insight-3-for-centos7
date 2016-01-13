public class WellKnownServiceTypeEntry : TypeEntry
{

	// Constructors
	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) {}
	public WellKnownServiceTypeEntry(Type type, string objectUri, WellKnownObjectMode mode) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ObjectUri { get{} }
	public WellKnownObjectMode Mode { get{} }
	public Type ObjectType { get{} }
	public System.Runtime.Remoting.Contexts.IContextAttribute[] ContextAttributes { get{} set{} }
	public string TypeName { get{} set{} }
	public string AssemblyName { get{} set{} }
}

