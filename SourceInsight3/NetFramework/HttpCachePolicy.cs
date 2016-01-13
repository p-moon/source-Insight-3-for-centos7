public class HttpCachePolicy
{

	// Methods
	public void SetNoServerCaching() {}
	public void SetVaryByCustom(string custom) {}
	public void AppendCacheExtension(string extension) {}
	public void SetNoTransforms() {}
	public void SetCacheability(HttpCacheability cacheability) {}
	public void SetCacheability(HttpCacheability cacheability, string field) {}
	public void SetNoStore() {}
	public void SetExpires(System.DateTime date) {}
	public void SetMaxAge(System.TimeSpan delta) {}
	public void SetProxyMaxAge(System.TimeSpan delta) {}
	public void SetSlidingExpiration(bool slide) {}
	public void SetValidUntilExpires(bool validUntilExpires) {}
	public void SetAllowResponseInBrowserHistory(bool allow) {}
	public void SetRevalidation(HttpCacheRevalidation revalidation) {}
	public void SetETag(string etag) {}
	public void SetLastModified(System.DateTime date) {}
	public void SetLastModifiedFromFileDependencies() {}
	public void SetETagFromFileDependencies() {}
	public void SetOmitVaryStar(bool omit) {}
	public void AddValidationCallback(HttpCacheValidateHandler handler, object data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpCacheVaryByContentEncodings VaryByContentEncodings { get{} }
	public HttpCacheVaryByHeaders VaryByHeaders { get{} }
	public HttpCacheVaryByParams VaryByParams { get{} }
}

