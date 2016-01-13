public class VsaEngineClass : System.__ComObject, Microsoft.Vsa.IVsaEngine, VsaEngine
{

	// Constructors
	public VsaEngineClass() {}

	// Methods
	public virtual object GetOption(string Name) {}
	public virtual void SetOption(string Name, object value) {}
	public virtual bool Compile() {}
	public virtual void Run() {}
	public virtual void Reset() {}
	public virtual void Close() {}
	public virtual void RevokeCache() {}
	public virtual void SaveSourceState(Microsoft.Vsa.IVsaPersistSite Site) {}
	public virtual void LoadSourceState(Microsoft.Vsa.IVsaPersistSite Site) {}
	public virtual void SaveCompiledState(out System.Byte[]& peout , System.Byte[]& pdb) {}
	public virtual void InitNew() {}
	public virtual bool IsValidIdentifier(string identifier) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Vsa.IVsaSite Site { get{} set{} }
	public string Name { get{} set{} }
	public string RootMoniker { get{} set{} }
	public string RootNamespace { get{} set{} }
	public int LCID { get{} set{} }
	public bool GenerateDebugInfo { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
	public Microsoft.Vsa.IVsaItems Items { get{} }
	public bool IsDirty { get{} }
	public string Language { get{} }
	public string Version { get{} }
	public bool IsRunning { get{} }
	public bool IsCompiled { get{} }
	public System.Reflection.Assembly Assembly { get{} }
}

