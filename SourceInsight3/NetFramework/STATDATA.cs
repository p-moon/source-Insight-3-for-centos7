public class STATDATA : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public FORMATETC formatetc;
	public ADVF advf;
	public IAdviseSink advSink;
	public int connection;
}

