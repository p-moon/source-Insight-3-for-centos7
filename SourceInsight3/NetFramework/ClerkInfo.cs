public class ClerkInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Clerk Clerk { get{} }
	public string InstanceId { get{} }
	public string Compensator { get{} }
	public string Description { get{} }
	public string TransactionUOW { get{} }
	public string ActivityId { get{} }
}

