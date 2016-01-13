public class AssemblyReference : BaseReference
{

	// Constructors
	public AssemblyReference() {}
	public AssemblyReference(string path) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AssemblyIdentity AssemblyIdentity { get{} set{} }
	public bool IsPrerequisite { get{} set{} }
	public AssemblyReferenceType ReferenceType { get{} set{} }
	public AssemblyIdentity XmlAssemblyIdentity { get{} set{} }
	public string XmlIsNative { get{} set{} }
	public string XmlIsPrerequisite { get{} set{} }
	public string Group { get{} set{} }
	public string Hash { get{} set{} }
	public bool IsOptional { get{} set{} }
	public string ResolvedPath { get{} set{} }
	public long Size { get{} set{} }
	public string SourcePath { get{} set{} }
	public string TargetPath { get{} set{} }
	public string XmlGroup { get{} set{} }
	public string XmlHash { get{} set{} }
	public string XmlHashAlgorithm { get{} set{} }
	public string XmlIsOptional { get{} set{} }
	public string XmlPath { get{} set{} }
	public string XmlSize { get{} set{} }
}

