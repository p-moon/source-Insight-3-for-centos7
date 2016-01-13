public class FileInfo : FileSystemInfo, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public FileInfo(string fileName) {}

	// Methods
	public virtual void Delete() {}
	public System.Security.AccessControl.FileSecurity GetAccessControl() {}
	public System.Security.AccessControl.FileSecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) {}
	public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) {}
	public StreamReader OpenText() {}
	public StreamWriter CreateText() {}
	public StreamWriter AppendText() {}
	public FileInfo CopyTo(string destFileName) {}
	public FileInfo CopyTo(string destFileName, bool overwrite) {}
	public FileStream Create() {}
	public void Decrypt() {}
	public void Encrypt() {}
	public FileStream Open(FileMode mode) {}
	public FileStream Open(FileMode mode, FileAccess access) {}
	public FileStream Open(FileMode mode, FileAccess access, FileShare share) {}
	public FileStream OpenRead() {}
	public FileStream OpenWrite() {}
	public void MoveTo(string destFileName) {}
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName) {}
	public FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) {}
	public virtual string ToString() {}
	public void Refresh() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public long Length { get{} }
	public string DirectoryName { get{} }
	public DirectoryInfo Directory { get{} }
	public bool IsReadOnly { get{} set{} }
	public bool Exists { get{} }
	public string FullName { get{} }
	public string Extension { get{} }
	public System.DateTime CreationTime { get{} set{} }
	public System.DateTime CreationTimeUtc { get{} set{} }
	public System.DateTime LastAccessTime { get{} set{} }
	public System.DateTime LastAccessTimeUtc { get{} set{} }
	public System.DateTime LastWriteTime { get{} set{} }
	public System.DateTime LastWriteTimeUtc { get{} set{} }
	public FileAttributes Attributes { get{} set{} }
}

