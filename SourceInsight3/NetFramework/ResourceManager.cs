public class ResourceManager
{

	// Constructors
	public ResourceManager(string baseName, System.Reflection.Assembly assembly) {}
	public ResourceManager(string baseName, System.Reflection.Assembly assembly, Type usingResourceSet) {}
	public ResourceManager(Type resourceSource) {}

	// Methods
	public virtual void ReleaseAllResources() {}
	public static ResourceManager CreateFileBasedResourceManager(string baseName, string resourceDir, Type usingResourceSet) {}
	public virtual ResourceSet GetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents) {}
	public virtual string GetString(string name) {}
	public virtual string GetString(string name, System.Globalization.CultureInfo culture) {}
	public virtual object GetObject(string name) {}
	public virtual object GetObject(string name, System.Globalization.CultureInfo culture) {}
	public System.IO.UnmanagedMemoryStream GetStream(string name) {}
	public System.IO.UnmanagedMemoryStream GetStream(string name, System.Globalization.CultureInfo culture) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int MagicNumber;
	public int HeaderVersionNumber;

	// Properties
	public string BaseName { get{} }
	public bool IgnoreCase { get{} set{} }
	public Type ResourceSetType { get{} }
}

