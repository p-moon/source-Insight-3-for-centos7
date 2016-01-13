public class SmtpMail
{

	// Methods
	public static void Send(string from, string to, string subject, string messageText) {}
	public static void Send(MailMessage message) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SmtpServer { get{} set{} }
}

