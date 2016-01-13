public class FixedLengthString
{

	// Constructors
	public FixedLengthString(int MaxChars) {}
	public FixedLengthString(int MaxChars, string InitialValue) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Value { get{} set{} }
}

