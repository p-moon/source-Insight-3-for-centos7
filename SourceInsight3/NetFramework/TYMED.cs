public class TYMED : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public TYMED TYMED_HGLOBAL;
	public TYMED TYMED_FILE;
	public TYMED TYMED_ISTREAM;
	public TYMED TYMED_ISTORAGE;
	public TYMED TYMED_GDI;
	public TYMED TYMED_MFPICT;
	public TYMED TYMED_ENHMF;
	public TYMED TYMED_NULL;
}

