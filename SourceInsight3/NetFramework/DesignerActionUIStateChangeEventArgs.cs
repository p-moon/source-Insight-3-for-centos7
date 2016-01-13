public class DesignerActionUIStateChangeEventArgs : System.EventArgs
{

	// Constructors
	public DesignerActionUIStateChangeEventArgs(object relatedObject, DesignerActionUIStateChangeType changeType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerActionUIStateChangeType ChangeType { get{} }
	public object RelatedObject { get{} }
}

