public interface IInternalConfigClientHost
{

	// Methods
	public abstract virtual bool IsExeConfig(string configPath) {}
	public abstract virtual bool IsRoamingUserConfig(string configPath) {}
	public abstract virtual bool IsLocalUserConfig(string configPath) {}
	public abstract virtual string GetExeConfigPath() {}
	public abstract virtual string GetRoamingUserConfigPath() {}
	public abstract virtual string GetLocalUserConfigPath() {}
}

