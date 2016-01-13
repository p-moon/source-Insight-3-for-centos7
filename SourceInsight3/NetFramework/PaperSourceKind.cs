public class PaperSourceKind : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public PaperSourceKind Upper;
	public PaperSourceKind Lower;
	public PaperSourceKind Middle;
	public PaperSourceKind Manual;
	public PaperSourceKind Envelope;
	public PaperSourceKind ManualFeed;
	public PaperSourceKind AutomaticFeed;
	public PaperSourceKind TractorFeed;
	public PaperSourceKind SmallFormat;
	public PaperSourceKind LargeFormat;
	public PaperSourceKind LargeCapacity;
	public PaperSourceKind Cassette;
	public PaperSourceKind FormSource;
	public PaperSourceKind Custom;
}

