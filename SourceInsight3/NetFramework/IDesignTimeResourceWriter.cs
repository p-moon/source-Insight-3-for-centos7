public interface IDesignTimeResourceWriter : System.Resources.IResourceWriter, System.IDisposable
{

	// Methods
	public abstract virtual string CreateResourceKey(string resourceName, object obj) {}
}

