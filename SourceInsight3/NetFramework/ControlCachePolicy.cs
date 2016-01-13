public class ControlCachePolicy
{

	// Methods
	public void SetVaryByCustom(string varyByCustom) {}
	public void SetSlidingExpiration(bool useSlidingExpiration) {}
	public void SetExpires(System.DateTime expirationTime) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SupportsCaching { get{} }
	public bool Cached { get{} set{} }
	public System.TimeSpan Duration { get{} set{} }
	public System.Web.HttpCacheVaryByParams VaryByParams { get{} }
	public string VaryByControl { get{} set{} }
	public System.Web.Caching.CacheDependency Dependency { get{} set{} }
}

