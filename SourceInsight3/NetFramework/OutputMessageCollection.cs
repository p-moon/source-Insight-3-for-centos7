public class OutputMessageCollection : System.Collections.IEnumerable
{

	// Methods
	public void Clear() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OutputMessage Item { get{} }
	public int ErrorCount { get{} }
	public int WarningCount { get{} }
}

