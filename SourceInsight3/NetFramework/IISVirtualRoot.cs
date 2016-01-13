public class IISVirtualRoot : IComSoapIISVRoot
{

	// Constructors
	public IISVirtualRoot() {}

	// Methods
	public virtual void Create(string RootWeb, string inPhysicalDirectory, string VirtualDirectoryout , System.String& Error) {}
	public virtual void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectoryout , System.String& Error) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

