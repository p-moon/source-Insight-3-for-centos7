public class SocketError : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public SocketError Success;
	public SocketError SocketError;
	public SocketError Interrupted;
	public SocketError AccessDenied;
	public SocketError Fault;
	public SocketError InvalidArgument;
	public SocketError TooManyOpenSockets;
	public SocketError WouldBlock;
	public SocketError InProgress;
	public SocketError AlreadyInProgress;
	public SocketError NotSocket;
	public SocketError DestinationAddressRequired;
	public SocketError MessageSize;
	public SocketError ProtocolType;
	public SocketError ProtocolOption;
	public SocketError ProtocolNotSupported;
	public SocketError SocketNotSupported;
	public SocketError OperationNotSupported;
	public SocketError ProtocolFamilyNotSupported;
	public SocketError AddressFamilyNotSupported;
	public SocketError AddressAlreadyInUse;
	public SocketError AddressNotAvailable;
	public SocketError NetworkDown;
	public SocketError NetworkUnreachable;
	public SocketError NetworkReset;
	public SocketError ConnectionAborted;
	public SocketError ConnectionReset;
	public SocketError NoBufferSpaceAvailable;
	public SocketError IsConnected;
	public SocketError NotConnected;
	public SocketError Shutdown;
	public SocketError TimedOut;
	public SocketError ConnectionRefused;
	public SocketError HostDown;
	public SocketError HostUnreachable;
	public SocketError ProcessLimit;
	public SocketError SystemNotReady;
	public SocketError VersionNotSupported;
	public SocketError NotInitialized;
	public SocketError Disconnecting;
	public SocketError TypeNotFound;
	public SocketError HostNotFound;
	public SocketError TryAgain;
	public SocketError NoRecovery;
	public SocketError NoData;
	public SocketError IOPending;
	public SocketError OperationAborted;
}

