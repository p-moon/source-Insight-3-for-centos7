public class DesignerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignerAttribute(string designerTypeName) {}
	public DesignerAttribute(Type designerType) {}
	public DesignerAttribute(string designerTypeName, string designerBaseTypeName) {}
	public DesignerAttribute(string designerTypeName, Type designerBaseType) {}
	public DesignerAttribute(Type designerType, Type designerBaseType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string DesignerBaseTypeName { get{} }
	public string DesignerTypeName { get{} }
	public object TypeId { get{} }
}

