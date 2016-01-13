public class X509Store
{

	// Constructors
	public X509Store() {}
	public X509Store(string storeName) {}
	public X509Store(StoreName storeName) {}
	public X509Store(StoreLocation storeLocation) {}
	public X509Store(StoreName storeName, StoreLocation storeLocation) {}
	public X509Store(string storeName, StoreLocation storeLocation) {}
	public X509Store(System.IntPtr storeHandle) {}

	// Methods
	public void Open(OpenFlags flags) {}
	public void Close() {}
	public void Add(X509Certificate2 certificate) {}
	public void AddRange(X509Certificate2Collection certificates) {}
	public void Remove(X509Certificate2 certificate) {}
	public void RemoveRange(X509Certificate2Collection certificates) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr StoreHandle { get{} }
	public StoreLocation Location { get{} }
	public string Name { get{} }
	public X509Certificate2Collection Certificates { get{} }
}

