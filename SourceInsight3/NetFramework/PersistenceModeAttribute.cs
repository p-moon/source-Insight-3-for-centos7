public class PersistenceModeAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PersistenceModeAttribute(PersistenceMode mode) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public PersistenceModeAttribute Attribute;
	public PersistenceModeAttribute InnerProperty;
	public PersistenceModeAttribute InnerDefaultProperty;
	public PersistenceModeAttribute EncodedInnerDefaultProperty;
	public PersistenceModeAttribute Default;

	// Properties
	public PersistenceMode Mode { get{} }
	public object TypeId { get{} }
}

