public class OracleDataAdapter : System.Data.Common.DbDataAdapter, System.ComponentModel.IComponent, System.IDisposable, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
{

	// Constructors
	public OracleDataAdapter() {}
	public OracleDataAdapter(OracleCommand selectCommand) {}
	public OracleDataAdapter(string selectCommandText, string selectConnectionString) {}
	public OracleDataAdapter(string selectCommandText, OracleConnection selectConnection) {}

	// Methods
	public System.Data.DataTable FillSchema(System.Data.DataTable dataTable, System.Data.SchemaType schemaType) {}
	public virtual System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType) {}
	public System.Data.DataTable[] FillSchema(System.Data.DataSet dataSet, System.Data.SchemaType schemaType, string srcTable) {}
	public virtual int Fill(System.Data.DataSet dataSet) {}
	public int Fill(System.Data.DataSet dataSet, string srcTable) {}
	public int Fill(System.Data.DataSet dataSet, int startRecord, int maxRecords, string srcTable) {}
	public int Fill(System.Data.DataTable dataTable) {}
	public int Fill(int startRecord, int maxRecords, System.Data.DataTable[] dataTables) {}
	public virtual System.Data.IDataParameter[] GetFillParameters() {}
	public virtual int Update(System.Data.DataSet dataSet) {}
	public int Update(System.Data.DataRow[] dataRows) {}
	public int Update(System.Data.DataTable dataTable) {}
	public int Update(System.Data.DataSet dataSet, string srcTable) {}
	public virtual bool ShouldSerializeAcceptChangesDuringFill() {}
	public void ResetFillLoadOption() {}
	public virtual bool ShouldSerializeFillLoadOption() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OracleCommand DeleteCommand { get{} set{} }
	public OracleCommand InsertCommand { get{} set{} }
	public OracleCommand SelectCommand { get{} set{} }
	public int UpdateBatchSize { get{} set{} }
	public OracleCommand UpdateCommand { get{} set{} }
	public System.Data.Common.DbCommand DeleteCommand { get{} set{} }
	public System.Data.Common.DbCommand InsertCommand { get{} set{} }
	public System.Data.Common.DbCommand SelectCommand { get{} set{} }
	public System.Data.Common.DbCommand UpdateCommand { get{} set{} }
	public bool AcceptChangesDuringFill { get{} set{} }
	public bool AcceptChangesDuringUpdate { get{} set{} }
	public bool ContinueUpdateOnError { get{} set{} }
	public System.Data.LoadOption FillLoadOption { get{} set{} }
	public System.Data.MissingMappingAction MissingMappingAction { get{} set{} }
	public System.Data.MissingSchemaAction MissingSchemaAction { get{} set{} }
	public bool ReturnProviderSpecificTypes { get{} set{} }
	public System.Data.Common.DataTableMappingCollection TableMappings { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Data.OracleClient.OracleRowUpdatedEventHandler RowUpdated;
	public event System.Data.OracleClient.OracleRowUpdatingEventHandler RowUpdating;
	public event System.Data.FillErrorEventHandler FillError;
	public event System.EventHandler Disposed;
}

