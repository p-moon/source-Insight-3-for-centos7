public interface IDataBindingSchemaProvider
{

	// Methods
	public abstract virtual void RefreshSchema(bool preferSilent) {}

	// Properties
	public bool CanRefreshSchema { get{} }
	public IDataSourceViewSchema Schema { get{} }
}

