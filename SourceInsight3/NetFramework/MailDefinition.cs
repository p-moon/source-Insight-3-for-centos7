public class MailDefinition : System.Web.UI.IStateManager
{

	// Constructors
	public MailDefinition() {}

	// Methods
	public System.Net.Mail.MailMessage CreateMailMessage(string recipients, System.Collections.IDictionary replacements, System.Web.UI.Control owner) {}
	public System.Net.Mail.MailMessage CreateMailMessage(string recipients, System.Collections.IDictionary replacements, string body, System.Web.UI.Control owner) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BodyFileName { get{} set{} }
	public string CC { get{} set{} }
	public string From { get{} set{} }
	public EmbeddedMailObjectsCollection EmbeddedObjects { get{} }
	public bool IsBodyHtml { get{} set{} }
	public System.Net.Mail.MailPriority Priority { get{} set{} }
	public string Subject { get{} set{} }
}

