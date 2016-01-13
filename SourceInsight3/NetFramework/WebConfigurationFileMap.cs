public class WebConfigurationFileMap : System.Configuration.ConfigurationFileMap, System.ICloneable
{

	// Constructors
	public WebConfigurationFileMap() {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public VirtualDirectoryMappingCollection VirtualDirectories { get{} }
	public string MachineConfigFilename { get{} set{} }
}

