public class DesignTimeVisibleAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignTimeVisibleAttribute(bool visible) {}
	public DesignTimeVisibleAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DesignTimeVisibleAttribute Yes;
	public DesignTimeVisibleAttribute No;
	public DesignTimeVisibleAttribute Default;

	// Properties
	public bool Visible { get{} }
	public object TypeId { get{} }
}

