public class DataSourceProviderService
{

	// Methods
	public abstract virtual DataSourceGroupCollection GetDataSources() {}
	public abstract virtual DataSourceGroup InvokeAddNewDataSource(System.Windows.Forms.IWin32Window parentWindow, System.Windows.Forms.FormStartPosition startPosition) {}
	public abstract virtual bool InvokeConfigureDataSource(System.Windows.Forms.IWin32Window parentWindow, System.Windows.Forms.FormStartPosition startPosition, DataSourceDescriptor dataSourceDescriptor) {}
	public abstract virtual object AddDataSourceInstance(System.ComponentModel.Design.IDesignerHost host, DataSourceDescriptor dataSourceDescriptor) {}
	public abstract virtual void NotifyDataSourceComponentAdded(object dsc) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SupportsAddNewDataSource { get{} }
	public bool SupportsConfigureDataSource { get{} }
}

