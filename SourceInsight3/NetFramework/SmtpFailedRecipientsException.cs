public class SmtpFailedRecipientsException : SmtpFailedRecipientException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public SmtpFailedRecipientsException() {}
	public SmtpFailedRecipientsException(string message) {}
	public SmtpFailedRecipientsException(string message, System.Exception innerException) {}
	public SmtpFailedRecipientsException(string message, SmtpFailedRecipientException[] innerExceptions) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SmtpFailedRecipientException[] InnerExceptions { get{} }
	public string FailedRecipient { get{} }
	public SmtpStatusCode StatusCode { get{} set{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

