public class VirtualDirectoryMapping
{

	// Constructors
	public VirtualDirectoryMapping(string physicalDirectory, bool isAppRoot) {}
	public VirtualDirectoryMapping(string physicalDirectory, bool isAppRoot, string configFileBaseName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string VirtualDirectory { get{} }
	public string PhysicalDirectory { get{} set{} }
	public bool IsAppRoot { get{} set{} }
	public string ConfigFileBaseName { get{} set{} }
}

