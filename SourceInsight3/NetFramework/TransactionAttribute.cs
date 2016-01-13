public class TransactionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public TransactionAttribute() {}
	public TransactionAttribute(TransactionOption val) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public TransactionOption Value { get{} }
	public TransactionIsolationLevel Isolation { get{} set{} }
	public int Timeout { get{} set{} }
	public object TypeId { get{} }
}

