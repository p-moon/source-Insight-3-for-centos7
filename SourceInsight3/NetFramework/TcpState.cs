public class TcpState : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TcpState Unknown;
	public TcpState Closed;
	public TcpState Listen;
	public TcpState SynSent;
	public TcpState SynReceived;
	public TcpState Established;
	public TcpState FinWait1;
	public TcpState FinWait2;
	public TcpState CloseWait;
	public TcpState Closing;
	public TcpState LastAck;
	public TcpState TimeWait;
	public TcpState DeleteTcb;
}

