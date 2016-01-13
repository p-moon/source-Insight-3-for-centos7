public class QUERY_SERVICE_CONFIG
{

	// Constructors
	public QUERY_SERVICE_CONFIG() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int dwServiceType;
	public int dwStartType;
	public int dwErrorControl;
	public System.Char* lpBinaryPathName;
	public System.Char* lpLoadOrderGroup;
	public int dwTagId;
	public System.Char* lpDependencies;
	public System.Char* lpServiceStartName;
	public System.Char* lpDisplayName;
}

