public class Clerk
{

	// Constructors
	public Clerk(Type compensator, string description, CompensatorOptions flags) {}
	public Clerk(string compensator, string description, CompensatorOptions flags) {}

	// Methods
	public void ForceLog() {}
	public void ForgetLogRecord() {}
	public void ForceTransactionToAbort() {}
	public void WriteLogRecord(object record) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TransactionUOW { get{} }
	public int LogRecordCount { get{} }
}

