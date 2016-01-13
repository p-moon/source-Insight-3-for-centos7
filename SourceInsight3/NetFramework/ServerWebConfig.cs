public class ServerWebConfig : IServerWebConfig
{

	// Constructors
	public ServerWebConfig() {}

	// Methods
	public virtual void Create(string FilePath, string FilePrefixout , System.String& Error) {}
	public virtual void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string WkoModeout , System.String& Error) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

