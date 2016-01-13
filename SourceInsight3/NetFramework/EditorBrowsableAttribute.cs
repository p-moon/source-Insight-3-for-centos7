public class EditorBrowsableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public EditorBrowsableAttribute(EditorBrowsableState state) {}
	public EditorBrowsableAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public EditorBrowsableState State { get{} }
	public object TypeId { get{} }
}

