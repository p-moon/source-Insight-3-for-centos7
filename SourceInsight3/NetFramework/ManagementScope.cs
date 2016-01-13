public class ManagementScope : System.ICloneable
{

	// Constructors
	public ManagementScope() {}
	public ManagementScope(ManagementPath path) {}
	public ManagementScope(string path) {}
	public ManagementScope(string path, ConnectionOptions options) {}
	public ManagementScope(ManagementPath path, ConnectionOptions options) {}

	// Methods
	public ManagementScope Clone() {}
	public void Connect() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsConnected { get{} }
	public ConnectionOptions Options { get{} set{} }
	public ManagementPath Path { get{} set{} }
}

