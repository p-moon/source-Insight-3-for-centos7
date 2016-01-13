public interface IDataSource
{

	// Methods
	public abstract virtual DataSourceView GetView(string viewName) {}
	public abstract virtual System.Collections.ICollection GetViewNames() {}

	// Events
	public event System.EventHandler DataSourceChanged;
}

