public class BaseVsaEngine : IVsaEngine
{

	// Methods
	public virtual void Close() {}
	public virtual bool Compile() {}
	public virtual object GetOption(string name) {}
	public virtual void InitNew() {}
	public virtual void LoadSourceState(IVsaPersistSite site) {}
	public virtual void Reset() {}
	public virtual void RevokeCache() {}
	public virtual void Run() {}
	public virtual void SetOption(string name, object value) {}
	public virtual void SaveCompiledState(out System.Byte[]& peout , System.Byte[]& debugInfo) {}
	public virtual void SaveSourceState(IVsaPersistSite site) {}
	public abstract virtual bool IsValidIdentifier(string ident) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System._AppDomain AppDomain { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
	public string ApplicationBase { get{} set{} }
	public System.Reflection.Assembly Assembly { get{} }
	public bool GenerateDebugInfo { get{} set{} }
	public bool IsCompiled { get{} }
	public bool IsDirty { get{} set{} }
	public bool IsRunning { get{} }
	public IVsaItems Items { get{} }
	public string Language { get{} }
	public int LCID { get{} set{} }
	public string Name { get{} set{} }
	public string RootMoniker { get{} set{} }
	public string RootNamespace { get{} set{} }
	public IVsaSite Site { get{} set{} }
	public string Version { get{} }
}

