public class ActiveDirectorySubnet : System.IDisposable
{

	// Constructors
	public ActiveDirectorySubnet(DirectoryContext context, string subnetName) {}
	public ActiveDirectorySubnet(DirectoryContext context, string subnetName, string siteName) {}

	// Methods
	public static ActiveDirectorySubnet FindByName(DirectoryContext context, string subnetName) {}
	public void Save() {}
	public void Delete() {}
	public virtual string ToString() {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ActiveDirectorySite Site { get{} set{} }
	public string Location { get{} set{} }
}

