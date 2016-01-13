public class ContextValue<T>
{

	// Constructors
	public ContextValue() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public T Value { get{} set{} }
}

