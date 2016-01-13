public class ToolboxDataAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ToolboxDataAttribute(string data) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ToolboxDataAttribute Default;

	// Properties
	public string Data { get{} }
	public object TypeId { get{} }
}

