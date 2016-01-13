public class FileSystemRights : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public FileSystemRights ReadData;
	public FileSystemRights ListDirectory;
	public FileSystemRights WriteData;
	public FileSystemRights CreateFiles;
	public FileSystemRights AppendData;
	public FileSystemRights CreateDirectories;
	public FileSystemRights ReadExtendedAttributes;
	public FileSystemRights WriteExtendedAttributes;
	public FileSystemRights ExecuteFile;
	public FileSystemRights Traverse;
	public FileSystemRights DeleteSubdirectoriesAndFiles;
	public FileSystemRights ReadAttributes;
	public FileSystemRights WriteAttributes;
	public FileSystemRights Delete;
	public FileSystemRights ReadPermissions;
	public FileSystemRights ChangePermissions;
	public FileSystemRights TakeOwnership;
	public FileSystemRights Synchronize;
	public FileSystemRights FullControl;
	public FileSystemRights Read;
	public FileSystemRights ReadAndExecute;
	public FileSystemRights Write;
	public FileSystemRights Modify;
}

