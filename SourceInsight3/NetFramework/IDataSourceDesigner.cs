public interface IDataSourceDesigner
{

	// Methods
	public abstract virtual void Configure() {}
	public abstract virtual DesignerDataSourceView GetView(string viewName) {}
	public abstract virtual string[] GetViewNames() {}
	public abstract virtual void RefreshSchema(bool preferSilent) {}
	public abstract virtual void ResumeDataSourceEvents() {}
	public abstract virtual void SuppressDataSourceEvents() {}

	// Properties
	public bool CanConfigure { get{} }
	public bool CanRefreshSchema { get{} }

	// Events
	public event System.EventHandler DataSourceChanged;
	public event System.EventHandler SchemaRefreshed;
}

