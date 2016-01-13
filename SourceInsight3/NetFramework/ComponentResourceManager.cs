public class ComponentResourceManager : System.Resources.ResourceManager
{

	// Constructors
	public ComponentResourceManager(Type t) {}
	public ComponentResourceManager() {}

	// Methods
	public void ApplyResources(object value, string objectName) {}
	public virtual void ApplyResources(object value, string objectName, System.Globalization.CultureInfo culture) {}
	public virtual void ReleaseAllResources() {}
	public virtual System.Resources.ResourceSet GetResourceSet(System.Globalization.CultureInfo culture, bool createIfNotExists, bool tryParents) {}
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

	// Properties
	public string BaseName { get{} }
	public bool IgnoreCase { get{} set{} }
	public Type ResourceSetType { get{} }
}

