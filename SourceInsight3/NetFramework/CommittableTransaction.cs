public class CommittableTransaction : Transaction, System.IDisposable, System.Runtime.Serialization.ISerializable, System.IAsyncResult
{

	// Constructors
	public CommittableTransaction() {}
	public CommittableTransaction(System.TimeSpan timeout) {}
	public CommittableTransaction(TransactionOptions options) {}

	// Methods
	public System.IAsyncResult BeginCommit(System.AsyncCallback asyncCallback, object asyncState) {}
	public void Commit() {}
	public void EndCommit(System.IAsyncResult asyncResult) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
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
	public TransactionInformation TransactionInformation { get{} }
	public IsolationLevel IsolationLevel { get{} }

	// Events
	public event System.Transactions.TransactionCompletedEventHandler TransactionCompleted;
}

