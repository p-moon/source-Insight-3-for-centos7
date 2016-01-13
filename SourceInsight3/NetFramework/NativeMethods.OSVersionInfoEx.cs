public class OSVersionInfoEx
{

	// Constructors
	public OSVersionInfoEx() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public uint dwOSVersionInfoSize;
	public uint dwMajorVersion;
	public uint dwMinorVersion;
	public uint dwBuildNumber;
	public uint dwPlatformId;
	public string szCSDVersion;
	public ushort wServicePackMajor;
	public ushort wServicePackMinor;
	public ushort wSuiteMask;
	public byte bProductType;
	public byte bReserved;
}

