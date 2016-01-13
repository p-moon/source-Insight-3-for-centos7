public class TransactionManager
{

	// Methods
	public static Enlistment Reenlist(System.Guid resourceManagerIdentifier, byte[] recoveryInformation, IEnlistmentNotification enlistmentNotification) {}
	public static void RecoveryComplete(System.Guid resourceManagerIdentifier) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HostCurrentTransactionCallback HostCurrentCallback { get{} set{} }
	public System.TimeSpan DefaultTimeout { get{} }
	public System.TimeSpan MaximumTimeout { get{} }

	// Events
	public event System.Transactions.TransactionStartedEventHandler DistributedTransactionStarted;
}

