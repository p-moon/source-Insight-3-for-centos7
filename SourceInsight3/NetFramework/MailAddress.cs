public class MailAddress
{

	// Constructors
	public MailAddress(string address) {}
	public MailAddress(string address, string displayName) {}
	public MailAddress(string address, string displayName, System.Text.Encoding displayNameEncoding) {}

	// Methods
	public virtual string ToString() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public string DisplayName { get{} }
	public string User { get{} }
	public string Host { get{} }
	public string Address { get{} }
}

