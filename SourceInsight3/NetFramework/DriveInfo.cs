public class DriveInfo : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public DriveInfo(string driveName) {}

	// Methods
	public static DriveInfo[] GetDrives() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public DriveType DriveType { get{} }
	public string DriveFormat { get{} }
	public bool IsReady { get{} }
	public long AvailableFreeSpace { get{} }
	public long TotalFreeSpace { get{} }
	public long TotalSize { get{} }
	public DirectoryInfo RootDirectory { get{} }
	public string VolumeLabel { get{} set{} }
}

