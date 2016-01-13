public class DesignerActionTextItem : DesignerActionItem
{

	// Constructors
	public DesignerActionTextItem(string displayName, string category) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowAssociate { get{} set{} }
	public string Category { get{} }
	public string Description { get{} }
	public string DisplayName { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

