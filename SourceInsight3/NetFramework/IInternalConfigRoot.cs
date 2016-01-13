public interface IInternalConfigRoot
{

	// Methods
	public abstract virtual void Init(IInternalConfigHost host, bool isDesignTime) {}
	public abstract virtual object GetSection(string section, string configPath) {}
	public abstract virtual string GetUniqueConfigPath(string configPath) {}
	public abstract virtual IInternalConfigRecord GetUniqueConfigRecord(string configPath) {}
	public abstract virtual IInternalConfigRecord GetConfigRecord(string configPath) {}
	public abstract virtual void RemoveConfig(string configPath) {}

	// Properties
	public bool IsDesignTime { get{} }

	// Events
	public event System.Configuration.Internal.InternalConfigEventHandler ConfigChanged;
	public event System.Configuration.Internal.InternalConfigEventHandler ConfigRemoved;
}

