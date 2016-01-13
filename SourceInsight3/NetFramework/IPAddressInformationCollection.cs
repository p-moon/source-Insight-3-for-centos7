public class IPAddressInformationCollection : ICollection<System.Net.NetworkInformation.IPAddressInformation>, IEnumerable<System.Net.NetworkInformation.IPAddressInformation>, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(IPAddressInformation[] array, int offset) {}
	public virtual void Add(IPAddressInformation address) {}
	public virtual bool Contains(IPAddressInformation address) {}
	public virtual IEnumerator<System.Net.NetworkInformation.IPAddressInformation> GetEnumerator() {}
	public virtual bool Remove(IPAddressInformation address) {}
	public virtual void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public IPAddressInformation Item { get{} }
}

