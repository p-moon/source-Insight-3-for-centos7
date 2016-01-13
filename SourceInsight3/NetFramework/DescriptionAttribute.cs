public class DescriptionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DescriptionAttribute() {}
	public DescriptionAttribute(string description) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DescriptionAttribute Default;

	// Properties
	public string Description { get{} }
	public object TypeId { get{} }
}

