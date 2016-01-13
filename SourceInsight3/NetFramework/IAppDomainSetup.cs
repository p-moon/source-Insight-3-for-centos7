public interface IAppDomainSetup
{

	// Properties
	public string ApplicationBase { get{} set{} }
	public string ApplicationName { get{} set{} }
	public string CachePath { get{} set{} }
	public string ConfigurationFile { get{} set{} }
	public string DynamicBase { get{} set{} }
	public string LicenseFile { get{} set{} }
	public string PrivateBinPath { get{} set{} }
	public string PrivateBinPathProbe { get{} set{} }
	public string ShadowCopyDirectories { get{} set{} }
	public string ShadowCopyFiles { get{} set{} }
}

