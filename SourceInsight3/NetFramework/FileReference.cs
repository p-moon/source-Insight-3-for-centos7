public class FileReference : BaseReference
{

	// Constructors
	public FileReference() {}
	public FileReference(string path) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ComClass[] ComClasses { get{} }
	public bool IsDataFile { get{} set{} }
	public ProxyStub[] ProxyStubs { get{} }
	public TypeLib[] TypeLibs { get{} }
	public ComClass[] XmlComClasses { get{} set{} }
	public ProxyStub[] XmlProxyStubs { get{} set{} }
	public TypeLib[] XmlTypeLibs { get{} set{} }
	public string XmlWriteableType { get{} set{} }
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

