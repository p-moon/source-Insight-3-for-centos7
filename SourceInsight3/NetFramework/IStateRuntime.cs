public interface IStateRuntime
{

	// Methods
	public abstract virtual void StopProcessing() {}
	public abstract virtual void ProcessRequest(System.IntPtr tracker, int verb, string uri, int exclusive, int timeout, int lockCookieExists, int lockCookie, int contentLength, System.IntPtr content) {}
	public abstract virtual void ProcessRequest(System.IntPtr tracker, int verb, string uri, int exclusive, int extraFlags, int timeout, int lockCookieExists, int lockCookie, int contentLength, System.IntPtr content) {}
}

