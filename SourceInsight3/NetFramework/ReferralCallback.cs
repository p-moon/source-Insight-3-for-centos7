public class ReferralCallback
{

	// Constructors
	public ReferralCallback() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public QueryForConnectionCallback QueryForConnection { get{} set{} }
	public NotifyOfNewConnectionCallback NotifyNewConnection { get{} set{} }
	public DereferenceConnectionCallback DereferenceConnection { get{} set{} }
}

