public class OracleCommandBuilder : System.Data.Common.DbCommandBuilder, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public OracleCommandBuilder() {}
	public OracleCommandBuilder(OracleDataAdapter adapter) {}

	// Methods
	public static void DeriveParameters(OracleCommand command) {}
	public OracleCommand GetInsertCommand() {}
	public OracleCommand GetInsertCommand(bool useColumnsForParameterNames) {}
	public OracleCommand GetUpdateCommand() {}
	public OracleCommand GetUpdateCommand(bool useColumnsForParameterNames) {}
	public OracleCommand GetDeleteCommand() {}
	public OracleCommand GetDeleteCommand(bool useColumnsForParameterNames) {}
	public virtual string QuoteIdentifier(string unquotedIdentifier) {}
	public virtual string UnquoteIdentifier(string quotedIdentifier) {}
	public System.Data.Common.DbCommand GetInsertCommand() {}
	public System.Data.Common.DbCommand GetInsertCommand(bool useColumnsForParameterNames) {}
	public System.Data.Common.DbCommand GetUpdateCommand() {}
	public System.Data.Common.DbCommand GetUpdateCommand(bool useColumnsForParameterNames) {}
	public System.Data.Common.DbCommand GetDeleteCommand() {}
	public System.Data.Common.DbCommand GetDeleteCommand(bool useColumnsForParameterNames) {}
	public virtual void RefreshSchema() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Data.Common.CatalogLocation CatalogLocation { get{} set{} }
	public string CatalogSeparator { get{} set{} }
	public OracleDataAdapter DataAdapter { get{} set{} }
	public string SchemaSeparator { get{} set{} }
	public System.Data.ConflictOption ConflictOption { get{} set{} }
	public System.Data.Common.DbDataAdapter DataAdapter { get{} set{} }
	public string QuotePrefix { get{} set{} }
	public string QuoteSuffix { get{} set{} }
	public bool SetAllValues { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

