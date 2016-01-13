public class BootstrapperBuilder : IBootstrapperBuilder
{

	// Constructors
	public BootstrapperBuilder() {}

	// Methods
	public virtual BuildResults Build(BuildSettings settings) {}
	public string[] GetOutputFolders(string[] productCodes, string culture, string fallbackCulture, ComponentsLocation componentsLocation) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Path { get{} set{} }
	public ProductCollection Products { get{} }
}

