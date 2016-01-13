public class SessionStateStoreData
{

	// Constructors
	public SessionStateStoreData(ISessionStateItemCollection sessionItems, System.Web.HttpStaticObjectsCollection staticObjects, int timeout) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ISessionStateItemCollection Items { get{} }
	public System.Web.HttpStaticObjectsCollection StaticObjects { get{} }
	public int Timeout { get{} set{} }
}

