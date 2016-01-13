public class DataSetFieldSchema : IDataSourceFieldSchema
{

	// Constructors
	public DataSetFieldSchema(System.Data.DataColumn column) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type DataType { get{} }
	public bool Identity { get{} }
	public bool IsReadOnly { get{} }
	public bool IsUnique { get{} }
	public int Length { get{} }
	public string Name { get{} }
	public bool Nullable { get{} }
	public int Precision { get{} }
	public bool PrimaryKey { get{} }
	public int Scale { get{} }
}

