public class AppDomainSetup : IAppDomainSetup
{

	// Constructors
	public AppDomainSetup() {}
	public AppDomainSetup(ActivationContext activationContext) {}
	public AppDomainSetup(System.Runtime.Hosting.ActivationArguments activationArguments) {}

	// Methods
	public byte[] GetConfigurationBytes() {}
	public void SetConfigurationBytes(byte[] value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationBase { get{} set{} }
	public string ConfigurationFile { get{} set{} }
	public string DynamicBase { get{} set{} }
	public bool DisallowPublisherPolicy { get{} set{} }
	public bool DisallowBindingRedirects { get{} set{} }
	public bool DisallowCodeDownload { get{} set{} }
	public bool DisallowApplicationBaseProbing { get{} set{} }
	public string ApplicationName { get{} set{} }
	public AppDomainInitializer AppDomainInitializer { get{} set{} }
	public string[] AppDomainInitializerArguments { get{} set{} }
	public System.Runtime.Hosting.ActivationArguments ActivationArguments { get{} set{} }
	public System.Security.Policy.ApplicationTrust ApplicationTrust { get{} set{} }
	public string PrivateBinPath { get{} set{} }
	public string PrivateBinPathProbe { get{} set{} }
	public string ShadowCopyDirectories { get{} set{} }
	public string ShadowCopyFiles { get{} set{} }
	public string CachePath { get{} set{} }
	public string LicenseFile { get{} set{} }
	public LoaderOptimization LoaderOptimization { get{} set{} }
	public bool SandboxInterop { get{} set{} }
}

