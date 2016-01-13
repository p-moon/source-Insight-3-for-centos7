public class LogRecord
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LogRecordFlags Flags { get{} }
	public int Sequence { get{} }
	public object Record { get{} }
}

