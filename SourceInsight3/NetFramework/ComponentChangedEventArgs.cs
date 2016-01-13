public class ComponentChangedEventArgs : System.EventArgs
{

	// Constructors
	public ComponentChangedEventArgs(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Component { get{} }
	public System.ComponentModel.MemberDescriptor Member { get{} }
	public object NewValue { get{} }
	public object OldValue { get{} }
}

