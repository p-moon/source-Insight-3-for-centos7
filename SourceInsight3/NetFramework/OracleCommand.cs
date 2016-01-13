public class OracleCommand : System.Data.Common.DbCommand, System.ComponentModel.IComponent, System.IDisposable, System.Data.IDbCommand, System.ICloneable
{

	// Constructors
	public OracleCommand() {}
	public OracleCommand(string commandText) {}
	public OracleCommand(string commandText, OracleConnection connection) {}
	public OracleCommand(string commandText, OracleConnection connection, OracleTransaction tx) {}

	// Methods
	public void ResetCommandTimeout() {}
	public virtual void Cancel() {}
	public virtual object Clone() {}
	public OracleParameter CreateParameter() {}
	public virtual int ExecuteNonQuery() {}
	public int ExecuteOracleNonQuery(out OracleString& rowid) {}
	public object ExecuteOracleScalar() {}
	public OracleDataReader ExecuteReader() {}
	public OracleDataReader ExecuteReader(System.Data.CommandBehavior behavior) {}
	public virtual object ExecuteScalar() {}
	public virtual void Prepare() {}
	public System.Data.Common.DbParameter CreateParameter() {}
	public System.Data.Common.DbDataReader ExecuteReader() {}
	public System.Data.Common.DbDataReader ExecuteReader(System.Data.CommandBehavior behavior) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CommandText { get{} set{} }
	public int CommandTimeout { get{} set{} }
	public System.Data.CommandType CommandType { get{} set{} }
	public OracleConnection Connection { get{} set{} }
	public bool DesignTimeVisible { get{} set{} }
	public OracleParameterCollection Parameters { get{} }
	public OracleTransaction Transaction { get{} set{} }
	public System.Data.UpdateRowSource UpdatedRowSource { get{} set{} }
	public System.Data.Common.DbConnection Connection { get{} set{} }
	public System.Data.Common.DbParameterCollection Parameters { get{} }
	public System.Data.Common.DbTransaction Transaction { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

