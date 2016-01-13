public class StreamingContextStates : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public StreamingContextStates CrossProcess;
	public StreamingContextStates CrossMachine;
	public StreamingContextStates File;
	public StreamingContextStates Persistence;
	public StreamingContextStates Remoting;
	public StreamingContextStates Other;
	public StreamingContextStates Clone;
	public StreamingContextStates CrossAppDomain;
	public StreamingContextStates All;
}

