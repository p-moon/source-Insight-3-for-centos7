public class FixedBufferAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public FixedBufferAttribute(Type elementType, int length) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ElementType { get{} }
	public int Length { get{} }
	public object TypeId { get{} }
}

