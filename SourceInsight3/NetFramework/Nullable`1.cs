public class Nullable<T> : ValueType
{

	// Constructors
	public Nullable(T value) {}

	// Methods
	public T GetValueOrDefault() {}
	public T GetValueOrDefault(T defaultValue) {}
	public virtual bool Equals(object other) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public static Nullable<T> op_Implicit(T value) {}
	public static T op_Explicit(Nullable<T> value) {}
	public Type GetType() {}

	// Properties
	public bool HasValue { get{} }
	public T Value { get{} }
}

