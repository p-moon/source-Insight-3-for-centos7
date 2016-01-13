public class NotifyParentPropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public NotifyParentPropertyAttribute(bool notifyParent) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public NotifyParentPropertyAttribute Yes;
	public NotifyParentPropertyAttribute No;
	public NotifyParentPropertyAttribute Default;

	// Properties
	public bool NotifyParent { get{} }
	public object TypeId { get{} }
}

