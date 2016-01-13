public class IPStatus : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public IPStatus Success;
	public IPStatus DestinationNetworkUnreachable;
	public IPStatus DestinationHostUnreachable;
	public IPStatus DestinationProtocolUnreachable;
	public IPStatus DestinationPortUnreachable;
	public IPStatus DestinationProhibited;
	public IPStatus NoResources;
	public IPStatus BadOption;
	public IPStatus HardwareError;
	public IPStatus PacketTooBig;
	public IPStatus TimedOut;
	public IPStatus BadRoute;
	public IPStatus TtlExpired;
	public IPStatus TtlReassemblyTimeExceeded;
	public IPStatus ParameterProblem;
	public IPStatus SourceQuench;
	public IPStatus BadDestination;
	public IPStatus DestinationUnreachable;
	public IPStatus TimeExceeded;
	public IPStatus BadHeader;
	public IPStatus UnrecognizedNextHeader;
	public IPStatus IcmpError;
	public IPStatus DestinationScopeMismatch;
	public IPStatus Unknown;
}

