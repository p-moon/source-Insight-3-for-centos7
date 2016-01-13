public class BrowsableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public BrowsableAttribute(bool browsable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public BrowsableAttribute Yes;
	public BrowsableAttribute No;
	public BrowsableAttribute Default;

	// Properties
	public bool Browsable { get{} }
	public object TypeId { get{} }
}

