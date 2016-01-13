public class ExeConfigurationFileMap : ConfigurationFileMap, System.ICloneable
{

	// Constructors
	public ExeConfigurationFileMap() {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ExeConfigFilename { get{} set{} }
	public string RoamingUserConfigFilename { get{} set{} }
	public string LocalUserConfigFilename { get{} set{} }
	public string MachineConfigFilename { get{} set{} }
}

