public class OracleConnection : System.Data.Common.DbConnection, System.ComponentModel.IComponent, System.IDisposable, System.Data.IDbConnection, System.ICloneable
{

	// Constructors
	public OracleConnection(string connectionString) {}
	public OracleConnection() {}

	// Methods
	public OracleTransaction BeginTransaction() {}
	public OracleTransaction BeginTransaction(System.Data.IsolationLevel il) {}
	public virtual void ChangeDatabase(string value) {}
	public static void ClearAllPools() {}
	public static void ClearPool(OracleConnection connection) {}
	public virtual void Close() {}
	public OracleCommand CreateCommand() {}
	public void EnlistDistributedTransaction(System.EnterpriseServices.ITransaction distributedTransaction) {}
	public virtual void Open() {}
	public virtual void EnlistTransaction(System.Transactions.Transaction transaction) {}
	public virtual System.Data.DataTable GetSchema() {}
	public virtual System.Data.DataTable GetSchema(string collectionName) {}
	public virtual System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) {}
	public System.Data.Common.DbTransaction BeginTransaction() {}
	public System.Data.Common.DbTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) {}
	public System.Data.Common.DbCommand CreateCommand() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ConnectionString { get{} set{} }
	public int ConnectionTimeout { get{} }
	public string Database { get{} }
	public string DataSource { get{} }
	public string ServerVersion { get{} }
	public System.Data.ConnectionState State { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Data.OracleClient.OracleInfoMessageEventHandler InfoMessage;
	public event System.Data.StateChangeEventHandler StateChange;
	public event System.EventHandler Disposed;
}

