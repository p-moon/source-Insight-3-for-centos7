public class DirectoryInfo : FileSystemInfo, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public DirectoryInfo(string path) {}

	// Methods
	public FileInfo[] GetFiles(string searchPattern) {}
	public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption) {}
	public DirectoryInfo[] GetDirectories() {}
	public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption) {}
	public DirectoryInfo CreateSubdirectory(string path) {}
	public DirectoryInfo CreateSubdirectory(string path, System.Security.AccessControl.DirectorySecurity directorySecurity) {}
	public void Create() {}
	public void Create(System.Security.AccessControl.DirectorySecurity directorySecurity) {}
	public System.Security.AccessControl.DirectorySecurity GetAccessControl() {}
	public System.Security.AccessControl.DirectorySecurity GetAccessControl(System.Security.AccessControl.AccessControlSections includeSections) {}
	public void SetAccessControl(System.Security.AccessControl.DirectorySecurity directorySecurity) {}
	public FileInfo[] GetFiles() {}
	public FileSystemInfo[] GetFileSystemInfos(string searchPattern) {}
	public FileSystemInfo[] GetFileSystemInfos() {}
	public DirectoryInfo[] GetDirectories(string searchPattern) {}
	public void MoveTo(string destDirName) {}
	public virtual void Delete() {}
	public void Delete(bool recursive) {}
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
	public DirectoryInfo Parent { get{} }
	public bool Exists { get{} }
	public DirectoryInfo Root { get{} }
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

