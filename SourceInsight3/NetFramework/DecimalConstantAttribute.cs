public class DecimalConstantAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) {}
	public DecimalConstantAttribute(byte scale, byte sign, int hi, int mid, int low) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public decimal Value { get{} }
	public object TypeId { get{} }
}

