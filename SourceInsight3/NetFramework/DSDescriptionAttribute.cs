public class DSDescriptionAttribute : System.ComponentModel.DescriptionAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DSDescriptionAttribute(string description) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Description { get{} }
	public object TypeId { get{} }
}

