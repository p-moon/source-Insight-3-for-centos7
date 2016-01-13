public class DesignerActionListsChangedEventArgs : System.EventArgs
{

	// Constructors
	public DesignerActionListsChangedEventArgs(object relatedObject, DesignerActionListsChangedType changeType, DesignerActionListCollection actionLists) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerActionListsChangedType ChangeType { get{} }
	public object RelatedObject { get{} }
	public DesignerActionListCollection ActionLists { get{} }
}

