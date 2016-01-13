public class IcmpV6Statistics
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public long DestinationUnreachableMessagesReceived { get{} }
	public long DestinationUnreachableMessagesSent { get{} }
	public long EchoRepliesReceived { get{} }
	public long EchoRepliesSent { get{} }
	public long EchoRequestsReceived { get{} }
	public long EchoRequestsSent { get{} }
	public long ErrorsReceived { get{} }
	public long ErrorsSent { get{} }
	public long MembershipQueriesReceived { get{} }
	public long MembershipQueriesSent { get{} }
	public long MembershipReductionsReceived { get{} }
	public long MembershipReductionsSent { get{} }
	public long MembershipReportsReceived { get{} }
	public long MembershipReportsSent { get{} }
	public long MessagesReceived { get{} }
	public long MessagesSent { get{} }
	public long NeighborAdvertisementsReceived { get{} }
	public long NeighborAdvertisementsSent { get{} }
	public long NeighborSolicitsReceived { get{} }
	public long NeighborSolicitsSent { get{} }
	public long PacketTooBigMessagesReceived { get{} }
	public long PacketTooBigMessagesSent { get{} }
	public long ParameterProblemsReceived { get{} }
	public long ParameterProblemsSent { get{} }
	public long RedirectsReceived { get{} }
	public long RedirectsSent { get{} }
	public long RouterAdvertisementsReceived { get{} }
	public long RouterAdvertisementsSent { get{} }
	public long RouterSolicitsReceived { get{} }
	public long RouterSolicitsSent { get{} }
	public long TimeExceededMessagesReceived { get{} }
	public long TimeExceededMessagesSent { get{} }
}

