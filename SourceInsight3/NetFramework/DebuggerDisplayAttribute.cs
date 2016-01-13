public class DebuggerDisplayAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DebuggerDisplayAttribute(string value) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Value { get{} }
	public string Name { get{} set{} }
	public string Type { get{} set{} }
	public Type Target { get{} set{} }
	public string TargetTypeName { get{} set{} }
	public object TypeId { get{} }
}

