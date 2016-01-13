public class CurrencyWrapper
{

	// Constructors
	public CurrencyWrapper(decimal obj) {}
	public CurrencyWrapper(object obj) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public decimal WrappedObject { get{} }
}

