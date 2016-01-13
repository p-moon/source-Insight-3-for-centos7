public class LayoutEventArgs : System.EventArgs
{

	// Constructors
	public LayoutEventArgs(System.ComponentModel.IComponent affectedComponent, string affectedProperty) {}
	public LayoutEventArgs(Control affectedControl, string affectedProperty) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IComponent AffectedComponent { get{} }
	public Control AffectedControl { get{} }
	public string AffectedProperty { get{} }
}

