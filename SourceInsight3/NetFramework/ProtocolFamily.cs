public class ProtocolFamily : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ProtocolFamily Unknown;
	public ProtocolFamily Unspecified;
	public ProtocolFamily Unix;
	public ProtocolFamily InterNetwork;
	public ProtocolFamily ImpLink;
	public ProtocolFamily Pup;
	public ProtocolFamily Chaos;
	public ProtocolFamily NS;
	public ProtocolFamily Ipx;
	public ProtocolFamily Iso;
	public ProtocolFamily Osi;
	public ProtocolFamily Ecma;
	public ProtocolFamily DataKit;
	public ProtocolFamily Ccitt;
	public ProtocolFamily Sna;
	public ProtocolFamily DecNet;
	public ProtocolFamily DataLink;
	public ProtocolFamily Lat;
	public ProtocolFamily HyperChannel;
	public ProtocolFamily AppleTalk;
	public ProtocolFamily NetBios;
	public ProtocolFamily VoiceView;
	public ProtocolFamily FireFox;
	public ProtocolFamily Banyan;
	public ProtocolFamily Atm;
	public ProtocolFamily InterNetworkV6;
	public ProtocolFamily Cluster;
	public ProtocolFamily Ieee12844;
	public ProtocolFamily Irda;
	public ProtocolFamily NetworkDesigners;
	public ProtocolFamily Max;
}

