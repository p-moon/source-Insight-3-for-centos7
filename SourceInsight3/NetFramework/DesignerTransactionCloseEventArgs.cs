public class DesignerTransactionCloseEventArgs : System.EventArgs
{

	// Constructors
	public DesignerTransactionCloseEventArgs(bool commit) {}
	public DesignerTransactionCloseEventArgs(bool commit, bool lastTransaction) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool TransactionCommitted { get{} }
	public bool LastTransaction { get{} }
}

