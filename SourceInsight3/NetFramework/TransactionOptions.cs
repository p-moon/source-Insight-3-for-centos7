public class TransactionOptions : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(TransactionOptions x, TransactionOptions y) {}
	public static bool op_Inequality(TransactionOptions x, TransactionOptions y) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.TimeSpan Timeout { get{} set{} }
	public IsolationLevel IsolationLevel { get{} set{} }
}

