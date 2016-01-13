public class ToolStripItemDesignerAvailabilityAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ToolStripItemDesignerAvailabilityAttribute() {}
	public ToolStripItemDesignerAvailabilityAttribute(ToolStripItemDesignerAvailability visibility) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ToolStripItemDesignerAvailabilityAttribute Default;

	// Properties
	public ToolStripItemDesignerAvailability ItemAdditionVisibility { get{} }
	public object TypeId { get{} }
}

