public interface IVsaSite
{

	// Methods
	public abstract virtual void GetCompiledState(out System.Byte[]& peout , System.Byte[]& debugInfo) {}
	public abstract virtual bool OnCompilerError(IVsaError error) {}
	public abstract virtual object GetGlobalInstance(string name) {}
	public abstract virtual object GetEventSourceInstance(string itemName, string eventSourceName) {}
	public abstract virtual void Notify(string notify, object info) {}
}

