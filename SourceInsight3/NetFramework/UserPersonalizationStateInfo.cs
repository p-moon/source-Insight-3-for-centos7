public class UserPersonalizationStateInfo : PersonalizationStateInfo
{

	// Constructors
	public UserPersonalizationStateInfo(string path, System.DateTime lastUpdatedDate, int size, string username, System.DateTime lastActivityDate) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Username { get{} }
	public System.DateTime LastActivityDate { get{} }
	public string Path { get{} }
	public System.DateTime LastUpdatedDate { get{} }
	public int Size { get{} }
}

