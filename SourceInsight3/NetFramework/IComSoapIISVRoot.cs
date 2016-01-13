public interface IComSoapIISVRoot
{

	// Methods
	public abstract virtual void Create(string RootWeb, string PhysicalDirectory, string VirtualDirectoryout , System.String& Error) {}
	public abstract virtual void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectoryout , System.String& Error) {}
}

