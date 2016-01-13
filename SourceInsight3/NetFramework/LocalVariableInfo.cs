public class LocalVariableInfo
{

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type LocalType { get{} }
	public bool IsPinned { get{} }
	public int LocalIndex { get{} }
}

