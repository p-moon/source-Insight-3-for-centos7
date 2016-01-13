public class ContextUtil
{

	// Methods
	public static void EnableCommit() {}
	public static void DisableCommit() {}
	public static void SetComplete() {}
	public static void SetAbort() {}
	public static bool IsCallerInRole(string role) {}
	public static bool IsDefaultContext() {}
	public static object GetNamedProperty(string name) {}
	public static void SetNamedProperty(string name, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsInTransaction { get{} }
	public bool IsSecurityEnabled { get{} }
	public object Transaction { get{} }
	public System.Transactions.Transaction SystemTransaction { get{} }
	public System.Guid TransactionId { get{} }
	public System.Guid ContextId { get{} }
	public System.Guid ActivityId { get{} }
	public TransactionVote MyTransactionVote { get{} set{} }
	public bool DeactivateOnReturn { get{} set{} }
	public System.Guid PartitionId { get{} }
	public System.Guid ApplicationId { get{} }
	public System.Guid ApplicationInstanceId { get{} }
}

