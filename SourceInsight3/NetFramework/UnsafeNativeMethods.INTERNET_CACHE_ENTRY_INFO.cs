public class INTERNET_CACHE_ENTRY_INFO : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int dwStructSize;
	public string lpszSourceUrlName;
	public string lpszLocalFileName;
	public CacheEntryType CacheEntryType;
	public int dwUseCount;
	public int dwHitRate;
	public int dwSizeLow;
	public int dwSizeHigh;
	public long LastModifiedTime;
	public long ExpireTime;
	public long LastAccessTime;
	public long LastSyncTime;
	public System.IntPtr lpHeaderInfo;
	public int dwHeaderInfoSize;
	public string lpszFileExtension;
	public int dwExemptData;
}

