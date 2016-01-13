public class StateRuntime : IStateRuntime
{

	// Constructors
	public StateRuntime() {}

	// Methods
	public virtual void StopProcessing() {}
	public virtual void ProcessRequest(System.IntPtr tracker, int verb, string uri, int exclusive, int timeout, int lockCookieExists, int lockCookie, int contentLength, System.IntPtr content) {}
	public virtual void ProcessRequest(System.IntPtr tracker, int verb, string uri, int exclusive, int extraFlags, int timeout, int lockCookieExists, int lockCookie, int contentLength, System.IntPtr content) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

