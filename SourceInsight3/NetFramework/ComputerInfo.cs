public class ComputerInfo
{

	// Constructors
	public ComputerInfo() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ulong TotalPhysicalMemory { get{} }
	public ulong AvailablePhysicalMemory { get{} }
	public ulong TotalVirtualMemory { get{} }
	public ulong AvailableVirtualMemory { get{} }
	public System.Globalization.CultureInfo InstalledUICulture { get{} }
	public string OSFullName { get{} }
	public string OSPlatform { get{} }
	public string OSVersion { get{} }
}

