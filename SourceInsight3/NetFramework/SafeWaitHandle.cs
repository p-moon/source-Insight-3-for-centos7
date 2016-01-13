public class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid, System.IDisposable
{

	// Constructors
	public SafeWaitHandle(System.IntPtr existingHandle, bool ownsHandle) {}

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
	public bool IsInvalid { get{} }
	public bool IsClosed { get{} }
}

