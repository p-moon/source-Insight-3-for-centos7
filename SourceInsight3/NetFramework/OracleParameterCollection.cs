public class OracleParameterCollection : System.Data.Common.DbParameterCollection, System.Data.IDataParameterCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public OracleParameterCollection() {}

	// Methods
	public OracleParameter Add(OracleParameter value) {}
	public OracleParameter Add(string parameterName, object value) {}
	public OracleParameter Add(string parameterName, OracleType dataType) {}
	public OracleParameter Add(string parameterName, OracleType dataType, int size) {}
	public OracleParameter Add(string parameterName, OracleType dataType, int size, string srcColumn) {}
	public void AddRange(OracleParameter[] values) {}
	public OracleParameter AddWithValue(string parameterName, object value) {}
	public virtual bool Contains(string parameterName) {}
	public bool Contains(OracleParameter value) {}
	public void CopyTo(OracleParameter[] array, int index) {}
	public int IndexOf(OracleParameter value) {}
	public void Insert(int index, OracleParameter value) {}
	public void Remove(OracleParameter value) {}
	public virtual int Add(object value) {}
	public virtual void AddRange(System.Array values) {}
	public virtual void Clear() {}
	public virtual bool Contains(object value) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual int IndexOf(string parameterName) {}
	public virtual int IndexOf(object value) {}
	public virtual void Insert(int index, object value) {}
	public virtual void Remove(object value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveAt(string parameterName) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OracleParameter Item { get{} set{} }
	public OracleParameter Item { get{} set{} }
	public int Count { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Data.Common.DbParameter Item { get{} set{} }
	public System.Data.Common.DbParameter Item { get{} set{} }
}

