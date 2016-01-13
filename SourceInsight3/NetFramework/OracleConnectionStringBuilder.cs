public class OracleConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor
{

	// Constructors
	public OracleConnectionStringBuilder() {}
	public OracleConnectionStringBuilder(string connectionString) {}

	// Methods
	public virtual void Clear() {}
	public virtual bool ContainsKey(string keyword) {}
	public virtual bool Remove(string keyword) {}
	public virtual bool ShouldSerialize(string keyword) {}
	public virtual bool TryGetValue(string keywordout , System.Object& value) {}
	public void Add(string keyword, object value) {}
	public virtual bool EquivalentTo(System.Data.Common.DbConnectionStringBuilder connectionStringBuilder) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public string DataSource { get{} set{} }
	public bool Enlist { get{} set{} }
	public bool IntegratedSecurity { get{} set{} }
	public int LoadBalanceTimeout { get{} set{} }
	public int MaxPoolSize { get{} set{} }
	public int MinPoolSize { get{} set{} }
	public bool OmitOracleConnectionName { get{} set{} }
	public string Password { get{} set{} }
	public bool PersistSecurityInfo { get{} set{} }
	public bool Pooling { get{} set{} }
	public bool Unicode { get{} set{} }
	public string UserID { get{} set{} }
	public bool IsFixedSize { get{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.ICollection Values { get{} }
	public bool BrowsableConnectionString { get{} set{} }
	public string ConnectionString { get{} set{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}

