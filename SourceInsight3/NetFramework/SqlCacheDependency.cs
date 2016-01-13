public class SqlCacheDependency : CacheDependency, System.IDisposable
{

	// Constructors
	public SqlCacheDependency(string databaseEntryName, string tableName) {}
	public SqlCacheDependency(System.Data.SqlClient.SqlCommand sqlCmd) {}

	// Methods
	public virtual string GetUniqueID() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool HasChanged { get{} }
	public System.DateTime UtcLastModified { get{} }
}

