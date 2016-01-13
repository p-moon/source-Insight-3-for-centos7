public class Cache : System.Collections.IEnumerable
{

	// Constructors
	public Cache() {}

	// Methods
	public System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public object Get(string key) {}
	public void Insert(string key, object value) {}
	public void Insert(string key, object value, CacheDependency dependencies) {}
	public void Insert(string key, object value, CacheDependency dependencies, System.DateTime absoluteExpiration, System.TimeSpan slidingExpiration) {}
	public void Insert(string key, object value, CacheDependency dependencies, System.DateTime absoluteExpiration, System.TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback) {}
	public object Add(string key, object value, CacheDependency dependencies, System.DateTime absoluteExpiration, System.TimeSpan slidingExpiration, CacheItemPriority priority, CacheItemRemovedCallback onRemoveCallback) {}
	public object Remove(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.DateTime NoAbsoluteExpiration;
	public System.TimeSpan NoSlidingExpiration;

	// Properties
	public int Count { get{} }
	public object Item { get{} set{} }
	public long EffectivePrivateBytesLimit { get{} }
	public long EffectivePercentagePhysicalMemoryLimit { get{} }
}

