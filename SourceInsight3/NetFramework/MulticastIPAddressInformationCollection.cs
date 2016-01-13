public class MulticastIPAddressInformationCollection : ICollection<System.Net.NetworkInformation.MulticastIPAddressInformation>, IEnumerable<System.Net.NetworkInformation.MulticastIPAddressInformation>, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(MulticastIPAddressInformation[] array, int offset) {}
	public virtual void Add(MulticastIPAddressInformation address) {}
	public virtual bool Contains(MulticastIPAddressInformation address) {}
	public virtual IEnumerator<System.Net.NetworkInformation.MulticastIPAddressInformation> GetEnumerator() {}
	public virtual bool Remove(MulticastIPAddressInformation address) {}
	public virtual void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public MulticastIPAddressInformation Item { get{} }
}

