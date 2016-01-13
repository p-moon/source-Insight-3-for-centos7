public class OracleInfoMessageEventArgs : System.EventArgs
{

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Code { get{} }
	public string Message { get{} }
	public string Source { get{} }
}

