public class ControlValuePropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ControlValuePropertyAttribute(string name) {}
	public ControlValuePropertyAttribute(string name, object defaultValue) {}
	public ControlValuePropertyAttribute(string name, Type type, string defaultValue) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} }
	public object DefaultValue { get{} }
	public object TypeId { get{} }
}

