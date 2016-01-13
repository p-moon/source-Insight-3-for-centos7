public class SerializationEntry : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public object Value { get{} }
	public string Name { get{} }
	public Type ObjectType { get{} }
}

