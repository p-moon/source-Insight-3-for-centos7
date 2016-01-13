public class CLSCompliantAttribute : Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public CLSCompliantAttribute(bool isCompliant) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsCompliant { get{} }
	public object TypeId { get{} }
}

