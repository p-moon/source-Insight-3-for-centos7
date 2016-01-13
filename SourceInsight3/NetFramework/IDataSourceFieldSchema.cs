public interface IDataSourceFieldSchema
{

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

