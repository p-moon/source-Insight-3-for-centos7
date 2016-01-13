public class StateItem
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDirty { get{} set{} }
	public object Value { get{} set{} }
}

