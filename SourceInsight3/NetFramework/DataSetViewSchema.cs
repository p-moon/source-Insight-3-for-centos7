public class DataSetViewSchema : IDataSourceViewSchema
{

	// Constructors
	public DataSetViewSchema(System.Data.DataTable dataTable) {}

	// Methods
	public virtual IDataSourceViewSchema[] GetChildren() {}
	public virtual IDataSourceFieldSchema[] GetFields() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
}

