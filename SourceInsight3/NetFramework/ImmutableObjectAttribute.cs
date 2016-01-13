public class ImmutableObjectAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ImmutableObjectAttribute(bool immutable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ImmutableObjectAttribute Yes;
	public ImmutableObjectAttribute No;
	public ImmutableObjectAttribute Default;

	// Properties
	public bool Immutable { get{} }
	public object TypeId { get{} }
}

