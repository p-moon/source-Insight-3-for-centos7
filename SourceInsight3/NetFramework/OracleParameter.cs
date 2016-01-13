public class OracleParameter : System.Data.Common.DbParameter, System.Data.IDbDataParameter, System.Data.IDataParameter, System.ICloneable
{

	// Constructors
	public OracleParameter() {}
	public OracleParameter(string name, object value) {}
	public OracleParameter(string name, OracleType oracleType) {}
	public OracleParameter(string name, OracleType oracleType, int size) {}
	public OracleParameter(string name, OracleType oracleType, int size, string srcColumn) {}
	public OracleParameter(string name, OracleType oracleType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) {}
	public OracleParameter(string name, OracleType oracleType, int size, System.Data.ParameterDirection direction, string sourceColumn, System.Data.DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value) {}

	// Methods
	public virtual void ResetDbType() {}
	public void ResetOracleType() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Data.DbType DbType { get{} set{} }
	public OracleType OracleType { get{} set{} }
	public string ParameterName { get{} set{} }
	public byte Precision { get{} set{} }
	public byte Scale { get{} set{} }
	public object Value { get{} set{} }
	public System.Data.ParameterDirection Direction { get{} set{} }
	public bool IsNullable { get{} set{} }
	public int Offset { get{} set{} }
	public int Size { get{} set{} }
	public string SourceColumn { get{} set{} }
	public bool SourceColumnNullMapping { get{} set{} }
	public System.Data.DataRowVersion SourceVersion { get{} set{} }
}

