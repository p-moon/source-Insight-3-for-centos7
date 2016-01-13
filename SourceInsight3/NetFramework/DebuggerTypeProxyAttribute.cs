public class DebuggerTypeProxyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DebuggerTypeProxyAttribute(Type type) {}
	public DebuggerTypeProxyAttribute(string typeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ProxyTypeName { get{} }
	public Type Target { get{} set{} }
	public string TargetTypeName { get{} set{} }
	public object TypeId { get{} }
}

