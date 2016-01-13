public class PhysicalAddress
{

	// Constructors
	public PhysicalAddress(byte[] address) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object comparand) {}
	public virtual string ToString() {}
	public byte[] GetAddressBytes() {}
	public static PhysicalAddress Parse(string address) {}
	public Type GetType() {}

	// Fields
	public PhysicalAddress None;
}

