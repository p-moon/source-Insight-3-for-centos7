public interface IVsaEngine
{

	// Methods
	public abstract virtual object GetOption(string name) {}
	public abstract virtual void SetOption(string name, object value) {}
	public abstract virtual bool Compile() {}
	public abstract virtual void Run() {}
	public abstract virtual void Reset() {}
	public abstract virtual void Close() {}
	public abstract virtual void RevokeCache() {}
	public abstract virtual void SaveSourceState(IVsaPersistSite site) {}
	public abstract virtual void LoadSourceState(IVsaPersistSite site) {}
	public abstract virtual void SaveCompiledState(out System.Byte[]& peout , System.Byte[]& pdb) {}
	public abstract virtual void InitNew() {}
	public abstract virtual bool IsValidIdentifier(string identifier) {}

	// Properties
	public IVsaSite Site { get{} set{} }
	public string Name { get{} set{} }
	public string RootMoniker { get{} set{} }
	public string RootNamespace { get{} set{} }
	public int LCID { get{} set{} }
	public bool GenerateDebugInfo { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
	public IVsaItems Items { get{} }
	public bool IsDirty { get{} }
	public string Language { get{} }
	public string Version { get{} }
	public bool IsRunning { get{} }
	public bool IsCompiled { get{} }
	public System.Reflection.Assembly Assembly { get{} }
}

