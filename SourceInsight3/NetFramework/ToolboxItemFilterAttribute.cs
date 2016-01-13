public class ToolboxItemFilterAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ToolboxItemFilterAttribute(string filterString) {}
	public ToolboxItemFilterAttribute(string filterString, ToolboxItemFilterType filterType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual string ToString() {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}

	// Properties
	public string FilterString { get{} }
	public ToolboxItemFilterType FilterType { get{} }
	public object TypeId { get{} }
}

