public class VBFixedArrayAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public VBFixedArrayAttribute(int UpperBound1) {}
	public VBFixedArrayAttribute(int UpperBound1, int UpperBound2) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int[] Bounds { get{} }
	public int Length { get{} }
	public object TypeId { get{} }
}

