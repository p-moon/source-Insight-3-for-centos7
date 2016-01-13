public class DirSyncRequestControl : DirectoryControl
{

	// Constructors
	public DirSyncRequestControl() {}
	public DirSyncRequestControl(byte[] cookie) {}
	public DirSyncRequestControl(byte[] cookie, DirectorySynchronizationOptions option) {}
	public DirSyncRequestControl(byte[] cookie, DirectorySynchronizationOptions option, int attributeCount) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] Cookie { get{} set{} }
	public DirectorySynchronizationOptions Option { get{} set{} }
	public int AttributeCount { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

