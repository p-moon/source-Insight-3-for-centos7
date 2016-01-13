public interface IConfigMapPathFactory
{

	// Methods
	public abstract virtual IConfigMapPath Create(string virtualPath, string physicalPath) {}
}

