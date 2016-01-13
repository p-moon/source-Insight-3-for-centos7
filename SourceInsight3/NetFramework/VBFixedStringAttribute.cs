public class VBFixedStringAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public VBFixedStringAttribute(int Length) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int Length { get{} }
	public object TypeId { get{} }
}

