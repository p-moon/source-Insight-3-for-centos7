public class ApplicationIdentity
{

	// Constructors
	public ApplicationIdentity(string url, string deployManifestPath, string applicationManifestPath) {}
	public ApplicationIdentity(string url, AssemblyIdentity deployManifestIdentity, AssemblyIdentity applicationManifestIdentity) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

