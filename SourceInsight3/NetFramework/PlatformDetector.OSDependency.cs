public class OSDependency
{

	// Constructors
	public OSDependency() {}
	public OSDependency(uint dwMajorVersion, uint dwMinorVersion, uint dwBuildNumber, ushort wServicePackMajor, ushort wServicePackMinor, string suiteName, string productName) {}
	public OSDependency(OSVersionInfoEx osvi) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public uint dwMajorVersion;
	public uint dwMinorVersion;
	public uint dwBuildNumber;
	public ushort wServicePackMajor;
	public ushort wServicePackMinor;
	public string suiteName;
	public string productName;
}

