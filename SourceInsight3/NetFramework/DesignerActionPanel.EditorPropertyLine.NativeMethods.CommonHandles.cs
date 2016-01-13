public class CommonHandles
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.Runtime.InteropServices.HandleCollector GdiHandleCollector;
	public System.Runtime.InteropServices.HandleCollector HdcHandleCollector;
}

