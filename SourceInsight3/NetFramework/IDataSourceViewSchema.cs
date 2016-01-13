public interface IDataSourceViewSchema
{

	// Methods
	public abstract virtual IDataSourceViewSchema[] GetChildren() {}
	public abstract virtual IDataSourceFieldSchema[] GetFields() {}

	// Properties
	public string Name { get{} }
}

