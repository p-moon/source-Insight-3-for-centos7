public interface IDesignerLoaderHost : System.ComponentModel.Design.IDesignerHost, System.ComponentModel.Design.IServiceContainer, System.IServiceProvider
{

	// Methods
	public abstract virtual void EndLoad(string baseClassName, bool successful, System.Collections.ICollection errorCollection) {}
	public abstract virtual void Reload() {}
}

