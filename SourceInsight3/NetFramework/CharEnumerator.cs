public class CharEnumerator : ICloneable, IEnumerator<char>, IDisposable, System.Collections.IEnumerator
{

	// Methods
	public virtual object Clone() {}
	public virtual bool MoveNext() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public char Current { get{} }
}

