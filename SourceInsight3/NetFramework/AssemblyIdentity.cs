public class AssemblyIdentity
{

	// Constructors
	public AssemblyIdentity() {}
	public AssemblyIdentity(string name) {}
	public AssemblyIdentity(string name, string version) {}
	public AssemblyIdentity(string name, string version, string publicKeyToken, string culture) {}
	public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture) {}
	public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture, string type) {}
	public AssemblyIdentity(AssemblyIdentity identity) {}

	// Methods
	public static AssemblyIdentity FromAssemblyName(string assemblyName) {}
	public static AssemblyIdentity FromManifest(string path) {}
	public static AssemblyIdentity FromManagedAssembly(string path) {}
	public static AssemblyIdentity FromNativeAssembly(string path) {}
	public static AssemblyIdentity FromFile(string path) {}
	public string GetFullName(FullNameFlags flags) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsFrameworkAssembly { get{} }
	public string Culture { get{} set{} }
	public bool IsNeutralPlatform { get{} }
	public bool IsStrongName { get{} }
	public string Name { get{} set{} }
	public string ProcessorArchitecture { get{} set{} }
	public string PublicKeyToken { get{} set{} }
	public string Type { get{} set{} }
	public string Version { get{} set{} }
	public string XmlName { get{} set{} }
	public string XmlVersion { get{} set{} }
	public string XmlPublicKeyToken { get{} set{} }
	public string XmlCulture { get{} set{} }
	public string XmlProcessorArchitecture { get{} set{} }
	public string XmlType { get{} set{} }
}

