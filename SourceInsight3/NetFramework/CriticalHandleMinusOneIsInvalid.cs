public class CriticalHandleMinusOneIsInvalid : System.Runtime.InteropServices.CriticalHandle, System.IDisposable
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
	public bool IsInvalid { get{} }
	public bool IsClosed { get{} }
}

