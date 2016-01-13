public class VsaEngine : Microsoft.Vsa.BaseVsaEngine, Microsoft.Vsa.IVsaEngine, Microsoft.JScript.IEngine2, Microsoft.JScript.IRedirectOutput
{

	// Constructors
	public VsaEngine() {}
	public VsaEngine(bool fast) {}

	// Methods
	public virtual Microsoft.Vsa.IVsaEngine Clone(System.AppDomain domain) {}
	public virtual bool CompileEmpty() {}
	public virtual void ConnectEvents() {}
	public static Microsoft.JScript.GlobalScope CreateEngineAndGetGlobalScope(bool fast, string[] assemblyNames) {}
	public static Microsoft.JScript.GlobalScope CreateEngineAndGetGlobalScopeWithType(bool fast, string[] assemblyNames, System.RuntimeTypeHandle callingTypeHandle) {}
	public static Microsoft.JScript.GlobalScope CreateEngineAndGetGlobalScopeWithTypeAndRootNamespace(bool fast, string[] assemblyNames, System.RuntimeTypeHandle callingTypeHandle, string rootNamespace) {}
	public static VsaEngine CreateEngine() {}
	public static VsaEngine CreateEngineWithType(System.RuntimeTypeHandle callingTypeHandle) {}
	public virtual void DisconnectEvents() {}
	public virtual System.Reflection.Assembly GetAssembly() {}
	public Microsoft.Vsa.IVsaItem GetItem(string itemName) {}
	public Microsoft.Vsa.IVsaItem GetItemAtIndex(int index) {}
	public int GetItemCount() {}
	public virtual Microsoft.JScript.IVsaScriptScope GetGlobalScope() {}
	public Microsoft.JScript.GlobalScope GetMainScope() {}
	public virtual System.Reflection.Module GetModule() {}
	public Microsoft.JScript.ArrayConstructor GetOriginalArrayConstructor() {}
	public Microsoft.JScript.ObjectConstructor GetOriginalObjectConstructor() {}
	public Microsoft.JScript.RegExpConstructor GetOriginalRegExpConstructor() {}
	public virtual void InitVsaEngine(string rootMoniker, Microsoft.Vsa.IVsaSite site) {}
	public virtual void Interrupt() {}
	public virtual bool IsValidIdentifier(string ident) {}
	public Microsoft.JScript.ScriptObject PopScriptObject() {}
	public void PushScriptObject(Microsoft.JScript.ScriptObject obj) {}
	public virtual void RegisterEventSource(string name) {}
	public virtual void Reset() {}
	public virtual void Restart() {}
	public virtual void RunEmpty() {}
	public virtual void Run(System.AppDomain domain) {}
	public Microsoft.JScript.ScriptObject ScriptObjectStackTop() {}
	public virtual void SetOutputStream(Microsoft.JScript.IMessageReceiver output) {}
	public virtual void Close() {}
	public virtual bool Compile() {}
	public virtual object GetOption(string name) {}
	public virtual void InitNew() {}
	public virtual void LoadSourceState(Microsoft.Vsa.IVsaPersistSite site) {}
	public virtual void RevokeCache() {}
	public virtual void Run() {}
	public virtual void SetOption(string name, object value) {}
	public virtual void SaveCompiledState(out System.Byte[]& peout , System.Byte[]& debugInfo) {}
	public virtual void SaveSourceState(Microsoft.Vsa.IVsaPersistSite site) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.JScript.LenientGlobalObject LenientGlobalObject { get{} }
	public System._AppDomain AppDomain { get{} set{} }
	public System.Security.Policy.Evidence Evidence { get{} set{} }
	public string ApplicationBase { get{} set{} }
	public System.Reflection.Assembly Assembly { get{} }
	public bool GenerateDebugInfo { get{} set{} }
	public bool IsCompiled { get{} }
	public bool IsDirty { get{} set{} }
	public bool IsRunning { get{} }
	public Microsoft.Vsa.IVsaItems Items { get{} }
	public string Language { get{} }
	public int LCID { get{} set{} }
	public string Name { get{} set{} }
	public string RootMoniker { get{} set{} }
	public string RootNamespace { get{} set{} }
	public Microsoft.Vsa.IVsaSite Site { get{} set{} }
	public string Version { get{} }
}

