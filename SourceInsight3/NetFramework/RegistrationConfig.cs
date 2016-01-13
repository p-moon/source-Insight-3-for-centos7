public class RegistrationConfig
{

	// Constructors
	public RegistrationConfig() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AssemblyFile { get{} set{} }
	public InstallationFlags InstallationFlags { get{} set{} }
	public string Application { get{} set{} }
	public string TypeLibrary { get{} set{} }
	public string Partition { get{} set{} }
	public string ApplicationRootDirectory { get{} set{} }
}

