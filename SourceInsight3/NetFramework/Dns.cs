public class Dns
{

	// Methods
	public static IPHostEntry GetHostByName(string hostName) {}
	public static IPHostEntry GetHostByAddress(string address) {}
	public static IPHostEntry GetHostByAddress(IPAddress address) {}
	public static string GetHostName() {}
	public static IPHostEntry Resolve(string hostName) {}
	public static System.IAsyncResult BeginGetHostByName(string hostName, System.AsyncCallback requestCallback, object stateObject) {}
	public static IPHostEntry EndGetHostByName(System.IAsyncResult asyncResult) {}
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) {}
	public static IPHostEntry GetHostEntry(IPAddress address) {}
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) {}
	public static System.IAsyncResult BeginGetHostEntry(string hostNameOrAddress, System.AsyncCallback requestCallback, object stateObject) {}
	public static System.IAsyncResult BeginGetHostEntry(IPAddress address, System.AsyncCallback requestCallback, object stateObject) {}
	public static IPHostEntry EndGetHostEntry(System.IAsyncResult asyncResult) {}
	public static System.IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, System.AsyncCallback requestCallback, object state) {}
	public static IPAddress[] EndGetHostAddresses(System.IAsyncResult asyncResult) {}
	public static System.IAsyncResult BeginResolve(string hostName, System.AsyncCallback requestCallback, object stateObject) {}
	public static IPHostEntry EndResolve(System.IAsyncResult asyncResult) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

