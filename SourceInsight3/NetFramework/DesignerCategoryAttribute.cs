public class DesignerCategoryAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignerCategoryAttribute() {}
	public DesignerCategoryAttribute(string category) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DesignerCategoryAttribute Component;
	public DesignerCategoryAttribute Default;
	public DesignerCategoryAttribute Form;
	public DesignerCategoryAttribute Generic;

	// Properties
	public string Category { get{} }
	public object TypeId { get{} }
}

