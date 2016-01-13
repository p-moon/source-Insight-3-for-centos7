public class Transactions
{

	// Constructors
	public Transactions() {}

	// Methods
	public static void InvokeTransacted(TransactedCallback callback, System.EnterpriseServices.TransactionOption mode) {}
	public static void InvokeTransacted(TransactedCallback callback, System.EnterpriseServices.TransactionOption mode, System.Boolean& transactionAborted) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

