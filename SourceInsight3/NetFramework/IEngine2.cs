public interface IEngine2
{

	// Methods
	public abstract virtual System.Reflection.Assembly GetAssembly() {}
	public abstract virtual void Run(System.AppDomain domain) {}
	public abstract virtual bool CompileEmpty() {}
	public abstract virtual void RunEmpty() {}
	public abstract virtual void DisconnectEvents() {}
	public abstract virtual void ConnectEvents() {}
	public abstract virtual void RegisterEventSource(string name) {}
	public abstract virtual void Interrupt() {}
	public abstract virtual void InitVsaEngine(string rootMoniker, Microsoft.Vsa.IVsaSite site) {}
	public abstract virtual IVsaScriptScope GetGlobalScope() {}
	public abstract virtual System.Reflection.Module GetModule() {}
	public abstract virtual Microsoft.Vsa.IVsaEngine Clone(System.AppDomain domain) {}
	public abstract virtual void Restart() {}
}

