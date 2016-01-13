public class DateTimeConstantAttribute : CustomConstantAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DateTimeConstantAttribute(long ticks) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object Value { get{} }
	public object TypeId { get{} }
}

