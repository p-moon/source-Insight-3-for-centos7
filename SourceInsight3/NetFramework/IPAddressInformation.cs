public class IPAddressInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.IPAddress Address { get{} }
	public bool IsDnsEligible { get{} }
	public bool IsTransient { get{} }
}

