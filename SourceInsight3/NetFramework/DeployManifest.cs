public class DeployManifest : Manifest
{

	// Constructors
	public DeployManifest() {}

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
	public string DeploymentUrl { get{} set{} }
	public bool DisallowUrlActivation { get{} set{} }
	public AssemblyReference EntryPoint { get{} set{} }
	public bool Install { get{} set{} }
	public bool MapFileExtensions { get{} set{} }
	public string MinimumRequiredVersion { get{} set{} }
	public string Product { get{} set{} }
	public string Publisher { get{} set{} }
	public string SupportUrl { get{} set{} }
	public bool TrustUrlParameters { get{} set{} }
	public bool UpdateEnabled { get{} set{} }
	public int UpdateInterval { get{} set{} }
	public UpdateMode UpdateMode { get{} set{} }
	public UpdateUnit UpdateUnit { get{} set{} }
	public string XmlDeploymentUrl { get{} set{} }
	public string XmlDisallowUrlActivation { get{} set{} }
	public string XmlInstall { get{} set{} }
	public string XmlMapFileExtensions { get{} set{} }
	public string XmlMinimumRequiredVersion { get{} set{} }
	public string XmlProduct { get{} set{} }
	public string XmlPublisher { get{} set{} }
	public string XmlSupportUrl { get{} set{} }
	public string XmlTrustUrlParameters { get{} set{} }
	public string XmlUpdateEnabled { get{} set{} }
	public string XmlUpdateInterval { get{} set{} }
	public string XmlUpdateMode { get{} set{} }
	public string XmlUpdateUnit { get{} set{} }
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

