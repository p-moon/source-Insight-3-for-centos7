public class EndpointPermission
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Hostname { get{} }
	public TransportType Transport { get{} }
	public int Port { get{} }
}

