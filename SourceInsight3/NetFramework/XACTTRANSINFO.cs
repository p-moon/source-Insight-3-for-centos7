public class XACTTRANSINFO : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public BOID uow;
	public int isoLevel;
	public int isoFlags;
	public int grfTCSupported;
	public int grfRMSupported;
	public int grfTCSupportedRetaining;
	public int grfRMSupportedRetaining;
}

