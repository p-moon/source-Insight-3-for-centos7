public class CriticalHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public void Close() {}
	public void SetHandleAsInvalid() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsClosed { get{} }
	public bool IsInvalid { get{} }
}

