public class IOControlCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public long value__;
	public IOControlCode AsyncIO;
	public IOControlCode NonBlockingIO;
	public IOControlCode DataToRead;
	public IOControlCode OobDataRead;
	public IOControlCode AssociateHandle;
	public IOControlCode EnableCircularQueuing;
	public IOControlCode Flush;
	public IOControlCode GetBroadcastAddress;
	public IOControlCode GetExtensionFunctionPointer;
	public IOControlCode GetQos;
	public IOControlCode GetGroupQos;
	public IOControlCode MultipointLoopback;
	public IOControlCode MulticastScope;
	public IOControlCode SetQos;
	public IOControlCode SetGroupQos;
	public IOControlCode TranslateHandle;
	public IOControlCode RoutingInterfaceQuery;
	public IOControlCode RoutingInterfaceChange;
	public IOControlCode AddressListQuery;
	public IOControlCode AddressListChange;
	public IOControlCode QueryTargetPnpHandle;
	public IOControlCode NamespaceChange;
	public IOControlCode AddressListSort;
	public IOControlCode ReceiveAll;
	public IOControlCode ReceiveAllMulticast;
	public IOControlCode ReceiveAllIgmpMulticast;
	public IOControlCode KeepAliveValues;
	public IOControlCode AbsorbRouterAlert;
	public IOControlCode UnicastInterface;
	public IOControlCode LimitBroadcasts;
	public IOControlCode BindToInterface;
	public IOControlCode MulticastInterface;
	public IOControlCode AddMulticastGroupOnInterface;
	public IOControlCode DeleteMulticastGroupFromInterface;
}

