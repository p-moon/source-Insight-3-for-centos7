public class SmtpClient
{

	// Constructors
	public SmtpClient() {}
	public SmtpClient(string host) {}
	public SmtpClient(string host, int port) {}

	// Methods
	public void Send(string from, string recipients, string subject, string body) {}
	public void Send(MailMessage message) {}
	public void SendAsync(string from, string recipients, string subject, string body, object userToken) {}
	public void SendAsync(MailMessage message, object userToken) {}
	public void SendAsyncCancel() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Host { get{} set{} }
	public int Port { get{} set{} }
	public bool UseDefaultCredentials { get{} set{} }
	public System.Net.ICredentialsByHost Credentials { get{} set{} }
	public int Timeout { get{} set{} }
	public System.Net.ServicePoint ServicePoint { get{} }
	public SmtpDeliveryMethod DeliveryMethod { get{} set{} }
	public string PickupDirectoryLocation { get{} set{} }
	public bool EnableSsl { get{} set{} }
	public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get{} }

	// Events
	public event System.Net.Mail.SendCompletedEventHandler SendCompleted;
}

