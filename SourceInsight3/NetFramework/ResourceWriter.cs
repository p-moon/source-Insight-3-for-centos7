public class ResourceWriter : IResourceWriter, System.IDisposable
{

	// Constructors
	public ResourceWriter(string fileName) {}
	public ResourceWriter(System.IO.Stream stream) {}

	// Methods
	public virtual void AddResource(string name, string value) {}
	public virtual void AddResource(string name, object value) {}
	public virtual void AddResource(string name, byte[] value) {}
	public void AddResourceData(string name, string typeName, byte[] serializedData) {}
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual void Generate() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

