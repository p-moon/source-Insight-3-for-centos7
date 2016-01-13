public class OracleClientFactory : System.Data.Common.DbProviderFactory
{

	// Methods
	public virtual System.Data.Common.DbCommand CreateCommand() {}
	public virtual System.Data.Common.DbCommandBuilder CreateCommandBuilder() {}
	public virtual System.Data.Common.DbConnection CreateConnection() {}
	public virtual System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() {}
	public virtual System.Data.Common.DbDataAdapter CreateDataAdapter() {}
	public virtual System.Data.Common.DbParameter CreateParameter() {}
	public virtual System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) {}
	public virtual System.Data.Common.DbDataSourceEnumerator CreateDataSourceEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public OracleClientFactory Instance;

	// Properties
	public bool CanCreateDataSourceEnumerator { get{} }
}

