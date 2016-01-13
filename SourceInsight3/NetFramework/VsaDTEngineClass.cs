public class VsaDTEngineClass : System.__ComObject, Microsoft.Vsa.IVsaDTEngine, VsaDTEngine
{

	// Constructors
	public VsaDTEngineClass() {}

	// Methods
	public virtual void InitCompleted() {}
	public virtual Microsoft.Vsa.IVsaIDE GetIDE() {}
	public virtual void AttachDebugger(bool isAttach) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TargetURL { get{} set{} }
}

