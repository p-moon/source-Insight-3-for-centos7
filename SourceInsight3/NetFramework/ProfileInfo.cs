public class ProfileInfo
{

	// Constructors
	public ProfileInfo(string username, bool isAnonymous, System.DateTime lastActivityDate, System.DateTime lastUpdatedDate, int size) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string UserName { get{} }
	public System.DateTime LastActivityDate { get{} }
	public System.DateTime LastUpdatedDate { get{} }
	public bool IsAnonymous { get{} }
	public int Size { get{} }
}

