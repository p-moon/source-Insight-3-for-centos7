public class QuotaControl : DirectoryControl
{

	// Constructors
	public QuotaControl() {}
	public QuotaControl(System.Security.Principal.SecurityIdentifier querySid) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Security.Principal.SecurityIdentifier QuerySid { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}

