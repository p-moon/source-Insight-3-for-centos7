public class PersistChildrenAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PersistChildrenAttribute(bool persist) {}
	public PersistChildrenAttribute(bool persist, bool usesCustomPersistence) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public PersistChildrenAttribute Yes;
	public PersistChildrenAttribute No;
	public PersistChildrenAttribute Default;

	// Properties
	public bool Persist { get{} }
	public bool UsesCustomPersistence { get{} }
	public object TypeId { get{} }
}

