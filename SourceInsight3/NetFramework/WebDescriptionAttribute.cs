public class WebDescriptionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebDescriptionAttribute() {}
	public WebDescriptionAttribute(string description) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public WebDescriptionAttribute Default;

	// Properties
	public string Description { get{} }
	public object TypeId { get{} }
}

