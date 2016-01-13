public interface IResourceWriter : System.IDisposable
{

	// Methods
	public abstract virtual void AddResource(string name, string value) {}
	public abstract virtual void AddResource(string name, object value) {}
	public abstract virtual void AddResource(string name, byte[] value) {}
	public abstract virtual void Close() {}
	public abstract virtual void Generate() {}
}

