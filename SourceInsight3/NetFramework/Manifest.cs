public class Manifest
{

	// Methods
	public void ResolveFiles() {}
	public void ResolveFiles(string[] searchPaths) {}
	public virtual string ToString() {}
	public void UpdateFileInfo() {}
	public virtual void Validate() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AssemblyIdentity AssemblyIdentity { get{} set{} }
	public AssemblyReferenceCollection AssemblyReferences { get{} }
	public string Description { get{} set{} }
	public AssemblyReference EntryPoint { get{} set{} }
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

