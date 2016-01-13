public class ComponentChangingEventArgs : System.EventArgs
{

	// Constructors
	public ComponentChangingEventArgs(object component, System.ComponentModel.MemberDescriptor member) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Component { get{} }
	public System.ComponentModel.MemberDescriptor Member { get{} }
}

