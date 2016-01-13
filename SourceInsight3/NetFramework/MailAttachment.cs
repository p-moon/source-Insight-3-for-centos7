public class MailAttachment
{

	// Constructors
	public MailAttachment(string filename) {}
	public MailAttachment(string filename, MailEncoding encoding) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Filename { get{} }
	public MailEncoding Encoding { get{} }
}

