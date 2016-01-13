public class VerifyNameControl : DirectoryControl
{

	// Constructors
	public VerifyNameControl() {}
	public VerifyNameControl(string serverName) {}
	public VerifyNameControl(string serverName, int flag) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ServerName { get{} set{} }
	public int Flag { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

