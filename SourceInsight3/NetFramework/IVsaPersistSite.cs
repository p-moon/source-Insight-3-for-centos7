public interface IVsaPersistSite
{

	// Methods
	public abstract virtual void SaveElement(string name, string source) {}
	public abstract virtual string LoadElement(string name) {}
}

