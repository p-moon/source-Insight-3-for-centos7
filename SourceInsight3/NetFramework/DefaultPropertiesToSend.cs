public class DefaultPropertiesToSend
{

	// Constructors
	public DefaultPropertiesToSend() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AcknowledgeTypes AcknowledgeType { get{} set{} }
	public MessageQueue AdministrationQueue { get{} set{} }
	public int AppSpecific { get{} set{} }
	public bool AttachSenderId { get{} set{} }
	public EncryptionAlgorithm EncryptionAlgorithm { get{} set{} }
	public byte[] Extension { get{} set{} }
	public HashAlgorithm HashAlgorithm { get{} set{} }
	public string Label { get{} set{} }
	public MessagePriority Priority { get{} set{} }
	public bool Recoverable { get{} set{} }
	public MessageQueue ResponseQueue { get{} set{} }
	public System.TimeSpan TimeToBeReceived { get{} set{} }
	public System.TimeSpan TimeToReachQueue { get{} set{} }
	public MessageQueue TransactionStatusQueue { get{} set{} }
	public bool UseAuthentication { get{} set{} }
	public bool UseDeadLetterQueue { get{} set{} }
	public bool UseEncryption { get{} set{} }
	public bool UseJournalQueue { get{} set{} }
	public bool UseTracing { get{} set{} }
}

