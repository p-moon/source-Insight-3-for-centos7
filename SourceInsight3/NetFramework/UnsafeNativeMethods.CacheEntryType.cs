public class CacheEntryType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public CacheEntryType None;
	public CacheEntryType Normal;
	public CacheEntryType Cookie;
	public CacheEntryType UrlHistory;
	public CacheEntryType TrackOffline;
	public CacheEntryType TrackOnline;
	public CacheEntryType Sticky;
	public CacheEntryType Sparse;
}

