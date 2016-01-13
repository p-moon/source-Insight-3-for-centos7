public class SYSTEM_INFO : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public ushort wProcessorArchitecture;
	public ushort wReserved;
	public uint dwPageSize;
	public System.IntPtr lpMinimumApplicationAddress;
	public System.IntPtr lpMaximumApplicationAddress;
	public System.IntPtr dwActiveProcessorMask;
	public uint dwNumberOfProcessors;
	public uint dwProcessorType;
	public uint dwAllocationGranularity;
	public ushort wProcessorLevel;
	public ushort wProcessorRevision;
}

