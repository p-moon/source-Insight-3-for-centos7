public class NetworkChange
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.Net.NetworkInformation.NetworkAvailabilityChangedEventHandler NetworkAvailabilityChanged;
	public event System.Net.NetworkInformation.NetworkAddressChangedEventHandler NetworkAddressChanged;
}

