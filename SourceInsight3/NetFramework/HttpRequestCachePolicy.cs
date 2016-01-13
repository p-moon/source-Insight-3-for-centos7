public class HttpRequestCachePolicy : RequestCachePolicy
{

	// Constructors
	public HttpRequestCachePolicy() {}
	public HttpRequestCachePolicy(HttpRequestCacheLevel level) {}
	public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, System.TimeSpan ageOrFreshOrStale) {}
	public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale) {}
	public HttpRequestCachePolicy(System.DateTime cacheSyncDate) {}
	public HttpRequestCachePolicy(HttpCacheAgeControl cacheAgeControl, System.TimeSpan maxAge, System.TimeSpan freshOrStale, System.DateTime cacheSyncDate) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpRequestCacheLevel Level { get{} }
	public System.DateTime CacheSyncDate { get{} }
	public System.TimeSpan MaxAge { get{} }
	public System.TimeSpan MinFresh { get{} }
	public System.TimeSpan MaxStale { get{} }
	public RequestCacheLevel Level { get{} }
}

