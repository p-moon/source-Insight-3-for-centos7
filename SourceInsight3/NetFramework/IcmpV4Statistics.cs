public class IcmpV4Statistics
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long AddressMaskRepliesReceived { get{} }
	public long AddressMaskRepliesSent { get{} }
	public long AddressMaskRequestsReceived { get{} }
	public long AddressMaskRequestsSent { get{} }
	public long DestinationUnreachableMessagesReceived { get{} }
	public long DestinationUnreachableMessagesSent { get{} }
	public long EchoRepliesReceived { get{} }
	public long EchoRepliesSent { get{} }
	public long EchoRequestsReceived { get{} }
	public long EchoRequestsSent { get{} }
	public long ErrorsReceived { get{} }
	public long ErrorsSent { get{} }
	public long MessagesReceived { get{} }
	public long MessagesSent { get{} }
	public long ParameterProblemsReceived { get{} }
	public long ParameterProblemsSent { get{} }
	public long RedirectsReceived { get{} }
	public long RedirectsSent { get{} }
	public long SourceQuenchesReceived { get{} }
	public long SourceQuenchesSent { get{} }
	public long TimeExceededMessagesReceived { get{} }
	public long TimeExceededMessagesSent { get{} }
	public long TimestampRepliesReceived { get{} }
	public long TimestampRepliesSent { get{} }
	public long TimestampRequestsReceived { get{} }
	public long TimestampRequestsSent { get{} }
}

