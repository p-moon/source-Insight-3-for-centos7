public class Transaction : System.IDisposable, System.Runtime.Serialization.ISerializable
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(Transaction x, Transaction y) {}
	public static bool op_Inequality(Transaction x, Transaction y) {}
	public Enlistment EnlistDurable(System.Guid resourceManagerIdentifier, IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) {}
	public Enlistment EnlistDurable(System.Guid resourceManagerIdentifier, ISinglePhaseNotification singlePhaseNotification, EnlistmentOptions enlistmentOptions) {}
	public void Rollback() {}
	public void Rollback(System.Exception e) {}
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) {}
	public Enlistment EnlistVolatile(ISinglePhaseNotification singlePhaseNotification, EnlistmentOptions enlistmentOptions) {}
	public Transaction Clone() {}
	public DependentTransaction DependentClone(DependentCloneOption cloneOption) {}
	public virtual void Dispose() {}
	public bool EnlistPromotableSinglePhase(IPromotableSinglePhaseNotification promotableSinglePhaseNotification) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Transaction Current { get{} set{} }
	public TransactionInformation TransactionInformation { get{} }
	public IsolationLevel IsolationLevel { get{} }

	// Events
	public event System.Transactions.TransactionCompletedEventHandler TransactionCompleted;
}

