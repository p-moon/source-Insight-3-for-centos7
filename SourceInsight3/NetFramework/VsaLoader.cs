public class VsaLoader : IVsaEngine
{

	// Constructors
	public VsaLoader() {}

	// Methods
	public virtual bool Compile() {}
	public virtual void Run() {}
	public virtual void Reset() {}
	public virtual void Close() {}
	public virtual void SaveSourceState(IVsaPersistSite Site) {}
	public virtual void LoadSourceState(IVsaPersistSite Site) {}
	public virtual void SaveCompiledState(out System.Byte[]& PEout , System.Byte[]& PDB) {}
	public virtual void RevokeCache() {}
	public virtual object GetOption(string name) {}
	public virtual void SetOption(string name, object value) {}
	public virtual void InitNew() {}
	public virtual bool IsValidIdentifier(string identifier) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IVsaSite Site { get{} set{} }
	public string Name { get{} set{} }
	public bool IsRunning { get{} }
	public bool IsCompiled { get{} }
	public IVsaItems Items { get{} }
	public string RootMoniker { get{} set{} }
	public string RootNamespace { get{} set{} }
	public bool GenerateDebugInfo { get{} set{} }
	public bool IsDirty { get{} }
	public string Language { get{} }
	public string Version { get{} }
	public System.Reflection.Assembly Assembly { get{} }
	public int LCID { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
}

