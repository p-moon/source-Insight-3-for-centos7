public class DataSetSchema : IDataSourceSchema
{

	// Constructors
	public DataSetSchema(System.Data.DataSet dataSet) {}

	// Methods
	public virtual IDataSourceViewSchema[] GetViews() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

