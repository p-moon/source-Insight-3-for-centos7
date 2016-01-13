public class TransactionOperation
{

	// Constructors
	public TransactionOperation(System.Deployment.Internal.Isolation.StoreTransactionOperation operation, uint disposition, int hresult) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Failed { get{} }
	public string FailureMessage { get{} }
}

