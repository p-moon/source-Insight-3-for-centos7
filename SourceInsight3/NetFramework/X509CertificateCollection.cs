public class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public X509CertificateCollection() {}
	public X509CertificateCollection(X509CertificateCollection value) {}
	public X509CertificateCollection(X509Certificate[] value) {}

	// Methods
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
	public X509Certificate Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

