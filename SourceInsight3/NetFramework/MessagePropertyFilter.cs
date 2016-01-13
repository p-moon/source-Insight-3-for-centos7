public class MessagePropertyFilter : System.ICloneable
{

	// Constructors
	public MessagePropertyFilter() {}

	// Methods
	public void ClearAll() {}
	public void SetDefaults() {}
	public void SetAll() {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Acknowledgment { get{} set{} }
	public bool AcknowledgeType { get{} set{} }
	public bool AdministrationQueue { get{} set{} }
	public bool AppSpecific { get{} set{} }
	public bool ArrivedTime { get{} set{} }
	public bool AttachSenderId { get{} set{} }
	public bool Authenticated { get{} set{} }
	public bool AuthenticationProviderName { get{} set{} }
	public bool AuthenticationProviderType { get{} set{} }
	public bool Body { get{} set{} }
	public bool ConnectorType { get{} set{} }
	public bool CorrelationId { get{} set{} }
	public int DefaultBodySize { get{} set{} }
	public int DefaultExtensionSize { get{} set{} }
	public int DefaultLabelSize { get{} set{} }
	public bool DestinationQueue { get{} set{} }
	public bool DestinationSymmetricKey { get{} set{} }
	public bool DigitalSignature { get{} set{} }
	public bool EncryptionAlgorithm { get{} set{} }
	public bool Extension { get{} set{} }
	public bool HashAlgorithm { get{} set{} }
	public bool Id { get{} set{} }
	public bool IsFirstInTransaction { get{} set{} }
	public bool IsLastInTransaction { get{} set{} }
	public bool Label { get{} set{} }
	public bool LookupId { get{} set{} }
	public bool MessageType { get{} set{} }
	public bool Priority { get{} set{} }
	public bool Recoverable { get{} set{} }
	public bool ResponseQueue { get{} set{} }
	public bool SenderCertificate { get{} set{} }
	public bool SenderId { get{} set{} }
	public bool SenderVersion { get{} set{} }
	public bool SentTime { get{} set{} }
	public bool SourceMachine { get{} set{} }
	public bool TimeToBeReceived { get{} set{} }
	public bool TimeToReachQueue { get{} set{} }
	public bool TransactionId { get{} set{} }
	public bool TransactionStatusQueue { get{} set{} }
	public bool UseAuthentication { get{} set{} }
	public bool UseDeadLetterQueue { get{} set{} }
	public bool UseEncryption { get{} set{} }
	public bool UseJournalQueue { get{} set{} }
	public bool UseTracing { get{} set{} }
}

