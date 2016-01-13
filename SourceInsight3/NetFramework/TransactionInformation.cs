public class TransactionInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string LocalIdentifier { get{} }
	public System.Guid DistributedIdentifier { get{} }
	public System.DateTime CreationTime { get{} }
	public TransactionStatus Status { get{} }
}

