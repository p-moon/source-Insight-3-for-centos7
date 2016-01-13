public class LocalizableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public LocalizableAttribute(bool isLocalizable) {}

	// Methods
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public LocalizableAttribute Yes;
	public LocalizableAttribute No;
	public LocalizableAttribute Default;

	// Properties
	public bool IsLocalizable { get{} }
	public object TypeId { get{} }
}

