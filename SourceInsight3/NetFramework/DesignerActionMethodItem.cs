public class DesignerActionMethodItem : DesignerActionItem
{

	// Constructors
	public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, string description, bool includeAsDesignerVerb) {}
	public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName) {}
	public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, bool includeAsDesignerVerb) {}
	public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category) {}
	public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, bool includeAsDesignerVerb) {}
	public DesignerActionMethodItem(DesignerActionList actionList, string memberName, string displayName, string category, string description) {}

	// Methods
	public virtual void Invoke() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MemberName { get{} }
	public System.ComponentModel.IComponent RelatedComponent { get{} set{} }
	public bool IncludeAsDesignerVerb { get{} }
	public bool AllowAssociate { get{} set{} }
	public string Category { get{} }
	public string Description { get{} }
	public string DisplayName { get{} }
	public System.Collections.IDictionary Properties { get{} }
}

