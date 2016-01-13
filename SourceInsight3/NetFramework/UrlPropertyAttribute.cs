public class UrlPropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public UrlPropertyAttribute() {}
	public UrlPropertyAttribute(string filter) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Filter { get{} }
	public object TypeId { get{} }
}

