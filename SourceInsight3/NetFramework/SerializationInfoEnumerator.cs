public class SerializationInfoEnumerator : System.Collections.IEnumerator
{

	// Methods
	public virtual bool MoveNext() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SerializationEntry Current { get{} }
	public string Name { get{} }
	public object Value { get{} }
	public Type ObjectType { get{} }
}

