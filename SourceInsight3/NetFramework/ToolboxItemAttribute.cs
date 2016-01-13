public class ToolboxItemAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ToolboxItemAttribute(bool defaultType) {}
	public ToolboxItemAttribute(string toolboxItemTypeName) {}
	public ToolboxItemAttribute(Type toolboxItemType) {}

	// Methods
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ToolboxItemAttribute Default;
	public ToolboxItemAttribute None;

	// Properties
	public Type ToolboxItemType { get{} }
	public string ToolboxItemTypeName { get{} }
	public object TypeId { get{} }
}

