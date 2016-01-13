public class OracleDataReader : System.Data.Common.DbDataReader, System.Data.IDataReader, System.IDisposable, System.Data.IDataRecord, System.Collections.IEnumerable
{

	// Methods
	public virtual void Close() {}
	public virtual string GetDataTypeName(int i) {}
	public virtual Type GetProviderSpecificFieldType(int i) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual Type GetFieldType(int i) {}
	public virtual string GetName(int i) {}
	public virtual int GetOrdinal(string name) {}
	public virtual System.Data.DataTable GetSchemaTable() {}
	public virtual object GetValue(int i) {}
	public virtual int GetValues(object[] values) {}
	public virtual bool GetBoolean(int i) {}
	public virtual byte GetByte(int i) {}
	public virtual long GetBytes(int i, long fieldOffset, byte[] buffer2, int bufferoffset, int length) {}
	public virtual char GetChar(int i) {}
	public virtual long GetChars(int i, long fieldOffset, char[] buffer2, int bufferoffset, int length) {}
	public virtual System.DateTime GetDateTime(int i) {}
	public virtual decimal GetDecimal(int i) {}
	public virtual double GetDouble(int i) {}
	public virtual float GetFloat(int i) {}
	public virtual System.Guid GetGuid(int i) {}
	public virtual short GetInt16(int i) {}
	public virtual int GetInt32(int i) {}
	public virtual long GetInt64(int i) {}
	public virtual object GetProviderSpecificValue(int i) {}
	public virtual int GetProviderSpecificValues(object[] values) {}
	public virtual string GetString(int i) {}
	public System.TimeSpan GetTimeSpan(int i) {}
	public OracleBFile GetOracleBFile(int i) {}
	public OracleBinary GetOracleBinary(int i) {}
	public OracleDateTime GetOracleDateTime(int i) {}
	public OracleLob GetOracleLob(int i) {}
	public OracleMonthSpan GetOracleMonthSpan(int i) {}
	public OracleNumber GetOracleNumber(int i) {}
	public OracleString GetOracleString(int i) {}
	public OracleTimeSpan GetOracleTimeSpan(int i) {}
	public object GetOracleValue(int i) {}
	public int GetOracleValues(object[] values) {}
	public virtual bool IsDBNull(int i) {}
	public virtual bool NextResult() {}
	public virtual bool Read() {}
	public virtual void Dispose() {}
	public System.Data.Common.DbDataReader GetData(int ordinal) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Depth { get{} }
	public int FieldCount { get{} }
	public bool HasRows { get{} }
	public bool IsClosed { get{} }
	public int RecordsAffected { get{} }
	public object Item { get{} }
	public object Item { get{} }
	public int VisibleFieldCount { get{} }
}

