public class SafeHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
{

	// Methods
	public void SetHandleAsInvalid() {}
	public void DangerousAddRef(System.Boolean& success) {}
	public void DangerousRelease() {}
	public virtual void Dispose() {}
	public System.IntPtr DangerousGetHandle() {}
	public void Close() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsClosed { get{} }
	public bool IsInvalid { get{} }
}

