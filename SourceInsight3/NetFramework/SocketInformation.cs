public class SocketInformation : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public byte[] ProtocolInformation { get{} set{} }
	public SocketInformationOptions Options { get{} set{} }
}

