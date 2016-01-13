public class ConfigurationFileMap : System.ICloneable
{

	// Constructors
	public ConfigurationFileMap() {}
	public ConfigurationFileMap(string machineConfigFilename) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MachineConfigFilename { get{} set{} }
}

