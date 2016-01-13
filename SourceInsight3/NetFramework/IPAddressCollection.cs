public class IPAddressCollection : ICollection<System.Net.IPAddress>, IEnumerable<System.Net.IPAddress>, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Net.IPAddress[] array, int offset) {}
	public virtual void Add(System.Net.IPAddress address) {}
	public virtual bool Contains(System.Net.IPAddress address) {}
	public virtual IEnumerator<System.Net.IPAddress> GetEnumerator() {}
	public virtual bool Remove(System.Net.IPAddress address) {}
	public virtual void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public System.Net.IPAddress Item { get{} }
}

