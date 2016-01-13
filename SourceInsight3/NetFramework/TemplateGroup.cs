public class TemplateGroup
{

	// Constructors
	public TemplateGroup(string groupName) {}
	public TemplateGroup(string groupName, System.Web.UI.WebControls.Style groupStyle) {}

	// Methods
	public void AddTemplateDefinition(TemplateDefinition templateDefinition) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsEmpty { get{} }
	public string GroupName { get{} }
	public System.Web.UI.WebControls.Style GroupStyle { get{} }
	public TemplateDefinition[] Templates { get{} }
}

