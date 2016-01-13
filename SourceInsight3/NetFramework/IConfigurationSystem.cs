public interface IConfigurationSystem
{

	// Methods
	public abstract virtual object GetConfig(string configKey) {}
	public abstract virtual void Init() {}
}

