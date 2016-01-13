public class ParameterModifier : System.ValueType
{

	// Constructors
	public ParameterModifier(int parameterCount) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public bool Item { get{} set{} }
}

