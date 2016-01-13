public class WebBrowsableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebBrowsableAttribute() {}
	public WebBrowsableAttribute(bool browsable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public WebBrowsableAttribute Yes;
	public WebBrowsableAttribute No;
	public WebBrowsableAttribute Default;

	// Properties
	public bool Browsable { get{} }
	public object TypeId { get{} }
}

