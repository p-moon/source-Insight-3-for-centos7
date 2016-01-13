public class MergablePropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public MergablePropertyAttribute(bool allowMerge) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public MergablePropertyAttribute Yes;
	public MergablePropertyAttribute No;
	public MergablePropertyAttribute Default;

	// Properties
	public bool AllowMerge { get{} }
	public object TypeId { get{} }
}

