public class NetworkInterface
{

	// Methods
	public static NetworkInterface[] GetAllNetworkInterfaces() {}
	public static bool GetIsNetworkAvailable() {}
	public abstract virtual IPInterfaceProperties GetIPProperties() {}
	public abstract virtual IPv4InterfaceStatistics GetIPv4Statistics() {}
	public abstract virtual PhysicalAddress GetPhysicalAddress() {}
	public abstract virtual bool Supports(NetworkInterfaceComponent networkInterfaceComponent) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int LoopbackInterfaceIndex { get{} }
	public string Id { get{} }
	public string Name { get{} }
	public string Description { get{} }
	public OperationalStatus OperationalStatus { get{} }
	public long Speed { get{} }
	public bool IsReceiveOnly { get{} }
	public bool SupportsMulticast { get{} }
	public NetworkInterfaceType NetworkInterfaceType { get{} }
}

