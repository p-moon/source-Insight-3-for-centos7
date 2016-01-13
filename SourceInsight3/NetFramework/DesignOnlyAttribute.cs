public class DesignOnlyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignOnlyAttribute(bool isDesignOnly) {}

	// Methods
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DesignOnlyAttribute Yes;
	public DesignOnlyAttribute No;
	public DesignOnlyAttribute Default;

	// Properties
	public bool IsDesignOnly { get{} }
	public object TypeId { get{} }
}

