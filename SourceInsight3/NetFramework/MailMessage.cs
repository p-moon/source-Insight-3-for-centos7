public class MailMessage : System.IDisposable
{

	// Constructors
	public MailMessage() {}
	public MailMessage(string from, string to) {}
	public MailMessage(string from, string to, string subject, string body) {}
	public MailMessage(MailAddress from, MailAddress to) {}

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MailAddress From { get{} set{} }
	public MailAddress Sender { get{} set{} }
	public MailAddress ReplyTo { get{} set{} }
	public MailAddressCollection To { get{} }
	public MailAddressCollection Bcc { get{} }
	public MailAddressCollection CC { get{} }
	public MailPriority Priority { get{} set{} }
	public DeliveryNotificationOptions DeliveryNotificationOptions { get{} set{} }
	public string Subject { get{} set{} }
	public System.Text.Encoding SubjectEncoding { get{} set{} }
	public System.Collections.Specialized.NameValueCollection Headers { get{} }
	public string Body { get{} set{} }
	public System.Text.Encoding BodyEncoding { get{} set{} }
	public bool IsBodyHtml { get{} set{} }
	public AttachmentCollection Attachments { get{} }
	public AlternateViewCollection AlternateViews { get{} }
}

