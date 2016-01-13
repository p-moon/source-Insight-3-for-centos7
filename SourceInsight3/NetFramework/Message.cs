public class Message : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public Message() {}
	public Message(object body) {}
	public Message(object body, IMessageFormatter formatter) {}

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.TimeSpan InfiniteTimeout;

	// Properties
	public Acknowledgment Acknowledgment { get{} }
	public AcknowledgeTypes AcknowledgeType { get{} set{} }
	public MessageQueue AdministrationQueue { get{} set{} }
	public int AppSpecific { get{} set{} }
	public System.DateTime ArrivedTime { get{} }
	public bool AttachSenderId { get{} set{} }
	public bool Authenticated { get{} }
	public string AuthenticationProviderName { get{} set{} }
	public CryptographicProviderType AuthenticationProviderType { get{} set{} }
	public object Body { get{} set{} }
	public System.IO.Stream BodyStream { get{} set{} }
	public int BodyType { get{} set{} }
	public System.Guid ConnectorType { get{} set{} }
	public string CorrelationId { get{} set{} }
	public MessageQueue DestinationQueue { get{} }
	public byte[] DestinationSymmetricKey { get{} set{} }
	public byte[] DigitalSignature { get{} set{} }
	public EncryptionAlgorithm EncryptionAlgorithm { get{} set{} }
	public byte[] Extension { get{} set{} }
	public IMessageFormatter Formatter { get{} set{} }
	public HashAlgorithm HashAlgorithm { get{} set{} }
	public string Id { get{} }
	public bool IsFirstInTransaction { get{} }
	public bool IsLastInTransaction { get{} }
	public string Label { get{} set{} }
	public long LookupId { get{} }
	public MessageType MessageType { get{} }
	public MessagePriority Priority { get{} set{} }
	public bool Recoverable { get{} set{} }
	public MessageQueue ResponseQueue { get{} set{} }
	public SecurityContext SecurityContext { get{} set{} }
	public byte[] SenderCertificate { get{} set{} }
	public byte[] SenderId { get{} }
	public long SenderVersion { get{} }
	public System.DateTime SentTime { get{} }
	public string SourceMachine { get{} }
	public System.TimeSpan TimeToBeReceived { get{} set{} }
	public System.TimeSpan TimeToReachQueue { get{} set{} }
	public string TransactionId { get{} }
	public MessageQueue TransactionStatusQueue { get{} set{} }
	public bool UseAuthentication { get{} set{} }
	public bool UseDeadLetterQueue { get{} set{} }
	public bool UseEncryption { get{} set{} }
	public bool UseJournalQueue { get{} set{} }
	public bool UseTracing { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

