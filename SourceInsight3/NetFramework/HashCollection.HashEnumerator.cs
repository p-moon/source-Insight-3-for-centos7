public class HashEnumerator : System.Collections.IEnumerator
{

	// Constructors
	public HashEnumerator(HashCollection hashCollection) {}

	// Methods
	public virtual void Reset() {}
	public virtual bool MoveNext() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Hash Current { get{} }
}

