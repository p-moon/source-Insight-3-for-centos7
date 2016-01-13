public class BaseVsaSite : IVsaSite
{

	// Constructors
	public BaseVsaSite() {}

	// Methods
	public virtual void GetCompiledState(out System.Byte[]& peout , System.Byte[]& debugInfo) {}
	public virtual object GetEventSourceInstance(string itemName, string eventSourceName) {}
	public virtual object GetGlobalInstance(string name) {}
	public virtual void Notify(string notify, object optional) {}
	public virtual bool OnCompilerError(IVsaError error) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public byte[] Assembly { get{} }
	public byte[] DebugInfo { get{} }
}

