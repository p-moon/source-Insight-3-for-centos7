public class SessionStateStoreProviderBase : System.Configuration.Provider.ProviderBase
{

	// Methods
	public abstract virtual void Dispose() {}
	public abstract virtual bool SetItemExpireCallback(SessionStateItemExpireCallback expireCallback) {}
	public abstract virtual void InitializeRequest(System.Web.HttpContext context) {}
	public abstract virtual SessionStateStoreData GetItem(System.Web.HttpContext context, string idout , System.Boolean& lockedout , System.TimeSpan& lockAgeout , System.Object& lockIdout , SessionStateActions& actions) {}
	public abstract virtual SessionStateStoreData GetItemExclusive(System.Web.HttpContext context, string idout , System.Boolean& lockedout , System.TimeSpan& lockAgeout , System.Object& lockIdout , SessionStateActions& actions) {}
	public abstract virtual void ReleaseItemExclusive(System.Web.HttpContext context, string id, object lockId) {}
	public abstract virtual void SetAndReleaseItemExclusive(System.Web.HttpContext context, string id, SessionStateStoreData item, object lockId, bool newItem) {}
	public abstract virtual void RemoveItem(System.Web.HttpContext context, string id, object lockId, SessionStateStoreData item) {}
	public abstract virtual void ResetItemTimeout(System.Web.HttpContext context, string id) {}
	public abstract virtual SessionStateStoreData CreateNewStoreData(System.Web.HttpContext context, int timeout) {}
	public abstract virtual void CreateUninitializedItem(System.Web.HttpContext context, string id, int timeout) {}
	public abstract virtual void EndRequest(System.Web.HttpContext context) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string Description { get{} }
}

