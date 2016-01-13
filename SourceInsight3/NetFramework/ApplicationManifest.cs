public class ApplicationManifest : AssemblyManifest
{

	// Constructors
	public ApplicationManifest() {}

	// Methods
	public virtual void Validate() {}
	public void ResolveFiles() {}
	public void ResolveFiles(string[] searchPaths) {}
	public virtual string ToString() {}
	public void UpdateFileInfo() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ConfigFile { get{} set{} }
	public AssemblyReference EntryPoint { get{} set{} }
	public string IconFile { get{} set{} }
	public bool IsClickOnceManifest { get{} set{} }
	public int MaxTargetPath { get{} set{} }
	public string OSDescription { get{} set{} }
	public string OSSupportUrl { get{} set{} }
	public string OSVersion { get{} set{} }
	public TrustInfo TrustInfo { get{} set{} }
	public string XmlConfigFile { get{} set{} }
	public AssemblyIdentity XmlEntryPointIdentity { get{} set{} }
	public string XmlEntryPointParameters { get{} set{} }
	public string XmlEntryPointPath { get{} set{} }
	public string XmlIconFile { get{} set{} }
	public string XmlIsClickOnceManifest { get{} set{} }
	public string XmlOSMajor { get{} set{} }
	public string XmlOSMinor { get{} set{} }
	public string XmlOSBuild { get{} set{} }
	public string XmlOSRevision { get{} set{} }
	public string XmlOSSupportUrl { get{} set{} }
	public string XmlOSDescription { get{} set{} }
	public ProxyStub[] ExternalProxyStubs { get{} }
	public ProxyStub[] XmlExternalProxyStubs { get{} set{} }
	public AssemblyIdentity AssemblyIdentity { get{} set{} }
	public AssemblyReferenceCollection AssemblyReferences { get{} }
	public string Description { get{} set{} }
	public FileReferenceCollection FileReferences { get{} }
	public System.IO.Stream InputStream { get{} set{} }
	public OutputMessageCollection OutputMessages { get{} }
	public bool ReadOnly { get{} set{} }
	public string SourcePath { get{} set{} }
	public AssemblyIdentity XmlAssemblyIdentity { get{} set{} }
	public AssemblyReference[] XmlAssemblyReferences { get{} set{} }
	public string XmlDescription { get{} set{} }
	public FileReference[] XmlFileReferences { get{} set{} }
	public string XmlSchema { get{} set{} }
}

