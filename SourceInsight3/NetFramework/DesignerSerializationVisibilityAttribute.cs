public class DesignerSerializationVisibilityAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DesignerSerializationVisibilityAttribute Content;
	public DesignerSerializationVisibilityAttribute Hidden;
	public DesignerSerializationVisibilityAttribute Visible;
	public DesignerSerializationVisibilityAttribute Default;

	// Properties
	public DesignerSerializationVisibility Visibility { get{} }
	public object TypeId { get{} }
}

