public class X509Certificate2Collection : X509CertificateCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public X509Certificate2Collection() {}
	public X509Certificate2Collection(X509Certificate2 certificate) {}
	public X509Certificate2Collection(X509Certificate2Collection certificates) {}
	public X509Certificate2Collection(X509Certificate2[] certificates) {}

	// Methods
	public int Add(X509Certificate2 certificate) {}
	public void AddRange(X509Certificate2[] certificates) {}
	public void AddRange(X509Certificate2Collection certificates) {}
	public bool Contains(X509Certificate2 certificate) {}
	public void Insert(int index, X509Certificate2 certificate) {}
	public X509Certificate2Enumerator GetEnumerator() {}
	public void Remove(X509Certificate2 certificate) {}
	public void RemoveRange(X509Certificate2[] certificates) {}
	public void RemoveRange(X509Certificate2Collection certificates) {}
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) {}
	public void Import(byte[] rawData) {}
	public void Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) {}
	public void Import(string fileName) {}
	public void Import(string fileName, string password, X509KeyStorageFlags keyStorageFlags) {}
	public byte[] Export(X509ContentType contentType) {}
	public byte[] Export(X509ContentType contentType, string password) {}
	public int Add(X509Certificate value) {}
	public void AddRange(X509Certificate[] value) {}
	public void AddRange(X509CertificateCollection value) {}
	public bool Contains(X509Certificate value) {}
	public void CopyTo(X509Certificate[] array, int index) {}
	public int IndexOf(X509Certificate value) {}
	public void Insert(int index, X509Certificate value) {}
	public X509CertificateEnumerator GetEnumerator() {}
	public void Remove(X509Certificate value) {}
	public virtual int GetHashCode() {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}

	// Properties
	public X509Certificate2 Item { get{} set{} }
	public X509Certificate Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

