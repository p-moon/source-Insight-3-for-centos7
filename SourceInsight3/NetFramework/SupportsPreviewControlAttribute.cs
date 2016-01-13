public class SupportsPreviewControlAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SupportsPreviewControlAttribute(bool supportsPreviewControl) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public SupportsPreviewControlAttribute Default;

	// Properties
	public bool SupportsPreviewControl { get{} }
	public object TypeId { get{} }
}

