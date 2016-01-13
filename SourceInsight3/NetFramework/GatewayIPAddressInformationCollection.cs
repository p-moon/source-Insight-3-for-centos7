public class GatewayIPAddressInformationCollection : ICollection<System.Net.NetworkInformation.GatewayIPAddressInformation>, IEnumerable<System.Net.NetworkInformation.GatewayIPAddressInformation>, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(GatewayIPAddressInformation[] array, int offset) {}
	public virtual void Add(GatewayIPAddressInformation address) {}
	public virtual bool Contains(GatewayIPAddressInformation address) {}
	public virtual IEnumerator<System.Net.NetworkInformation.GatewayIPAddressInformation> GetEnumerator() {}
	public virtual bool Remove(GatewayIPAddressInformation address) {}
	public virtual void Clear() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsReadOnly { get{} }
	public GatewayIPAddressInformation Item { get{} }
}

