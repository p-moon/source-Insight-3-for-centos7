public class WININET_CACHE_ENTRY : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public WININET_CACHE_ENTRY NORMAL_CACHE_ENTRY;
	public WININET_CACHE_ENTRY COOKIE_CACHE_ENTRY;
	public WININET_CACHE_ENTRY URLHISTORY_CACHE_ENTRY;
	public WININET_CACHE_ENTRY TRACK_OFFLINE_CACHE_ENTRY;
	public WININET_CACHE_ENTRY TRACK_ONLINE_CACHE_ENTRY;
	public WININET_CACHE_ENTRY STICKY_CACHE_ENTRY;
	public WININET_CACHE_ENTRY SPARSE_CACHE_ENTRY;
}

