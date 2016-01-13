public interface IDataEnvironment
{

	// Methods
	public abstract virtual DesignerDataConnection BuildConnection(System.Windows.Forms.IWin32Window owner, DesignerDataConnection initialConnection) {}
	public abstract virtual string BuildQuery(System.Windows.Forms.IWin32Window owner, DesignerDataConnection connection, QueryBuilderMode mode, string initialQueryText) {}
	public abstract virtual DesignerDataConnection ConfigureConnection(System.Windows.Forms.IWin32Window owner, DesignerDataConnection connection, string name) {}
	public abstract virtual IDesignerDataSchema GetConnectionSchema(DesignerDataConnection connection) {}
	public abstract virtual System.Data.Common.DbConnection GetDesignTimeConnection(DesignerDataConnection connection) {}
	public abstract virtual System.CodeDom.CodeExpression GetCodeExpression(DesignerDataConnection connection) {}

	// Properties
	public System.Collections.ICollection Connections { get{} }
}

