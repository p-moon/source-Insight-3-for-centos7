public class GlobalProxySelection
{

	// Constructors
	public GlobalProxySelection() {}

	// Methods
	public static IWebProxy GetEmptyWebProxy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IWebProxy Select { get{} set{} }
}

