public class ResXResourceWriter : IResourceWriter, System.IDisposable
{

	// Constructors
	public ResXResourceWriter(string fileName) {}
	public ResXResourceWriter(System.IO.Stream stream) {}
	public ResXResourceWriter(System.IO.TextWriter textWriter) {}

	// Methods
	public virtual void AddAlias(string aliasName, System.Reflection.AssemblyName assemblyName) {}
	public void AddMetadata(string name, byte[] value) {}
	public void AddMetadata(string name, string value) {}
	public void AddMetadata(string name, object value) {}
	public virtual void AddResource(string name, byte[] value) {}
	public virtual void AddResource(string name, object value) {}
	public virtual void AddResource(string name, string value) {}
	public void AddResource(ResXDataNode node) {}
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual void Generate() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string BinSerializedObjectMimeType;
	public string SoapSerializedObjectMimeType;
	public string DefaultSerializedObjectMimeType;
	public string ByteArraySerializedObjectMimeType;
	public string ResMimeType;
	public string Version;
	public string ResourceSchema;

	// Properties
	public string BasePath { get{} set{} }
}

