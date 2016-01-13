public class FileSystemInfo : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
{

	// Methods
	public abstract virtual void Delete() {}
	public void Refresh() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FullName { get{} }
	public string Extension { get{} }
	public string Name { get{} }
	public bool Exists { get{} }
	public System.DateTime CreationTime { get{} set{} }
	public System.DateTime CreationTimeUtc { get{} set{} }
	public System.DateTime LastAccessTime { get{} set{} }
	public System.DateTime LastAccessTimeUtc { get{} set{} }
	public System.DateTime LastWriteTime { get{} set{} }
	public System.DateTime LastWriteTimeUtc { get{} set{} }
	public FileAttributes Attributes { get{} set{} }
}

