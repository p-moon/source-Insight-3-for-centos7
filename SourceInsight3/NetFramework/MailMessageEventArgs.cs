public class MailMessageEventArgs : LoginCancelEventArgs
{

	// Constructors
	public MailMessageEventArgs(System.Net.Mail.MailMessage message) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.Mail.MailMessage Message { get{} }
	public bool Cancel { get{} set{} }
}

