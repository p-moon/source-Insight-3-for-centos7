public class SqlExecutionException : System.SystemException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public SqlExecutionException(string message, string server, string database, string sqlFile, string commands, System.Data.SqlClient.SqlException sqlException) {}
	public SqlExecutionException(string message) {}
	public SqlExecutionException(string message, System.Exception innerException) {}
	public SqlExecutionException() {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Server { get{} }
	public string Database { get{} }
	public string SqlFile { get{} }
	public string Commands { get{} }
	public System.Data.SqlClient.SqlException Exception { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

