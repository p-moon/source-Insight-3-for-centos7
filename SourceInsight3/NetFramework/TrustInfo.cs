public class TrustInfo
{

	// Constructors
	public TrustInfo() {}

	// Methods
	public void Clear() {}
	public void Read(string path) {}
	public void Read(System.IO.Stream input) {}
	public void ReadManifest(string path) {}
	public void ReadManifest(System.IO.Stream input) {}
	public virtual string ToString() {}
	public void Write(string path) {}
	public void Write(System.IO.Stream output) {}
	public void WriteManifest(string path) {}
	public void WriteManifest(System.IO.Stream output) {}
	public void WriteManifest(System.IO.Stream input, System.IO.Stream output) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool HasUnmanagedCodePermission { get{} }
	public bool IsFullTrust { get{} set{} }
	public System.Security.PermissionSet PermissionSet { get{} set{} }
	public bool PreserveFullTrustPermissionSet { get{} set{} }
	public string SameSiteAccess { get{} set{} }
}

