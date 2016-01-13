public class DesignerActionPropertyItem : DesignerActionItem
{

	// Constructors
	public DesignerActionPropertyItem(string memberName, string displayName, string category, string description) {}
	public DesignerActionPropertyItem(string memberName, string displayName) {}
	public DesignerActionPropertyItem(string memberName, string displayName, string category) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MemberName { get{} }
	public System.ComponentModel.IComponent RelatedComponent { get{} set{} }
	public bool AllowAssociate { get{} set{} }
	public string Category { get{} }
	public string Description { get{} }
	public string DisplayName { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

