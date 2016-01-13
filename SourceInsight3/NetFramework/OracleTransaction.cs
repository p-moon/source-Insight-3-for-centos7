public class OracleTransaction : System.Data.Common.DbTransaction, System.Data.IDbTransaction, System.IDisposable
{

	// Methods
	public virtual void Commit() {}
	public virtual void Rollback() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OracleConnection Connection { get{} }
	public System.Data.IsolationLevel IsolationLevel { get{} }
	public System.Data.Common.DbConnection Connection { get{} }
}

