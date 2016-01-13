public interface IWebApplication : System.IServiceProvider
{

	// Methods
	public abstract virtual IProjectItem GetProjectItemFromUrl(string appRelativeUrl) {}
	public abstract virtual System.Configuration.Configuration OpenWebConfiguration(bool isReadOnly) {}

	// Properties
	public IProjectItem RootProjectItem { get{} }
}

