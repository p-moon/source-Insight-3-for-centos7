public class ManagementObjectEnumerator : System.Collections.IEnumerator, System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual bool MoveNext() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementBaseObject Current { get{} }
}

