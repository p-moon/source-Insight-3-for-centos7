public class UnicastIPAddressInformationCollection : ICollection<System.Net.NetworkInformation.UnicastIPAddressInformation>, IEnumerable<System.Net.NetworkInformation.UnicastIPAddressInformation>, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(UnicastIPAddressInformation[] array, int offset) {}
	public virtual void Add(UnicastIPAddressInformation address) {}
	public virtual bool Contains(UnicastIPAddressInformation address) {}
	public virtual IEnumerator<System.Net.NetworkInformation.UnicastIPAddressInformation> GetEnumerator() {}
	public virtual bool Remove(UnicastIPAddressInformation address) {}
	public virtual void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public UnicastIPAddressInformation Item { get{} }
}

