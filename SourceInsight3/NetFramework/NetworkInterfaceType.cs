public class NetworkInterfaceType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public NetworkInterfaceType Unknown;
	public NetworkInterfaceType Ethernet;
	public NetworkInterfaceType TokenRing;
	public NetworkInterfaceType Fddi;
	public NetworkInterfaceType BasicIsdn;
	public NetworkInterfaceType PrimaryIsdn;
	public NetworkInterfaceType Ppp;
	public NetworkInterfaceType Loopback;
	public NetworkInterfaceType Ethernet3Megabit;
	public NetworkInterfaceType Slip;
	public NetworkInterfaceType Atm;
	public NetworkInterfaceType GenericModem;
	public NetworkInterfaceType FastEthernetT;
	public NetworkInterfaceType Isdn;
	public NetworkInterfaceType FastEthernetFx;
	public NetworkInterfaceType Wireless80211;
	public NetworkInterfaceType AsymmetricDsl;
	public NetworkInterfaceType RateAdaptDsl;
	public NetworkInterfaceType SymmetricDsl;
	public NetworkInterfaceType VeryHighSpeedDsl;
	public NetworkInterfaceType IPOverAtm;
	public NetworkInterfaceType GigabitEthernet;
	public NetworkInterfaceType Tunnel;
	public NetworkInterfaceType MultiRateSymmetricDsl;
	public NetworkInterfaceType HighPerformanceSerialBus;
}

