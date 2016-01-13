public interface IInternalConfigSystem
{

	// Methods
	public abstract virtual object GetSection(string configKey) {}
	public abstract virtual void RefreshConfig(string sectionName) {}

	// Properties
	public bool SupportsUserConfig { get{} }
}

