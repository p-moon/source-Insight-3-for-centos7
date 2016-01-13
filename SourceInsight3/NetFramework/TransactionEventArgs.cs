public class TransactionEventArgs : System.EventArgs
{

	// Constructors
	public TransactionEventArgs() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Transaction Transaction { get{} }
}

