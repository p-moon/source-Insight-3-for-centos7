public interface IConfigurationManagerInternal
{

	// Properties
	public bool SupportsUserConfig { get{} }
	public bool SetConfigurationSystemInProgress { get{} }
	public string MachineConfigPath { get{} }
	public string ApplicationConfigUri { get{} }
	public string ExeProductName { get{} }
	public string ExeProductVersion { get{} }
	public string ExeRoamingConfigDirectory { get{} }
	public string ExeRoamingConfigPath { get{} }
	public string ExeLocalConfigDirectory { get{} }
	public string ExeLocalConfigPath { get{} }
	public string UserConfigFilename { get{} }
}

