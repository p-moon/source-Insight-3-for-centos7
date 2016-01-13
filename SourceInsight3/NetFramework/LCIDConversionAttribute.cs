public class LCIDConversionAttribute : System.Attribute, _Attribute
{

	// Constructors
	public LCIDConversionAttribute(int lcid) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int Value { get{} }
	public object TypeId { get{} }
}

