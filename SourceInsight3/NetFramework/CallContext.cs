public class CallContext
{

	// Methods
	public static void FreeNamedDataSlot(string name) {}
	public static object LogicalGetData(string name) {}
	public static object GetData(string name) {}
	public static void SetData(string name, object data) {}
	public static void LogicalSetData(string name, object data) {}
	public static Header[] GetHeaders() {}
	public static void SetHeaders(Header[] headers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object HostContext { get{} set{} }
}

