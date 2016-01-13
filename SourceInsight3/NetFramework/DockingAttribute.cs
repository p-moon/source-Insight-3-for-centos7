public class DockingAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DockingAttribute() {}
	public DockingAttribute(DockingBehavior dockingBehavior) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DockingAttribute Default;

	// Properties
	public DockingBehavior DockingBehavior { get{} }
	public object TypeId { get{} }
}

