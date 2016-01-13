public class BindableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public BindableAttribute(bool bindable) {}
	public BindableAttribute(bool bindable, BindingDirection direction) {}
	public BindableAttribute(BindableSupport flags) {}
	public BindableAttribute(BindableSupport flags, BindingDirection direction) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public BindableAttribute Yes;
	public BindableAttribute No;
	public BindableAttribute Default;

	// Properties
	public bool Bindable { get{} }
	public BindingDirection Direction { get{} }
	public object TypeId { get{} }
}

