public class URL_PART : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public URL_PART NONE;
	public URL_PART SCHEME;
	public URL_PART HOSTNAME;
	public URL_PART USERNAME;
	public URL_PART PASSWORD;
	public URL_PART PORT;
	public URL_PART QUERY;
}

