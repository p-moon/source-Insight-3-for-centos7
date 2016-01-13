public class TransactionScope : System.IDisposable
{

	// Constructors
	public TransactionScope() {}
	public TransactionScope(TransactionScopeOption scopeOption) {}
	public TransactionScope(TransactionScopeOption scopeOption, System.TimeSpan scopeTimeout) {}
	public TransactionScope(TransactionScopeOption scopeOption, TransactionOptions transactionOptions) {}
	public TransactionScope(TransactionScopeOption scopeOption, TransactionOptions transactionOptions, EnterpriseServicesInteropOption interopOption) {}
	public TransactionScope(Transaction transactionToUse) {}
	public TransactionScope(Transaction transactionToUse, System.TimeSpan scopeTimeout) {}
	public TransactionScope(Transaction transactionToUse, System.TimeSpan scopeTimeout, EnterpriseServicesInteropOption interopOption) {}

	// Methods
	public virtual void Dispose() {}
	public void Complete() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

