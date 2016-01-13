public class Compensator : System.EnterpriseServices.ServicedComponent, System.EnterpriseServices.IRemoteDispatch, System.IDisposable, System.EnterpriseServices.IManagedObject, System.EnterpriseServices.IServicedComponentInfo, _ICompensator, _IFormatLogRecords
{

	// Constructors
	public Compensator() {}

	// Methods
	public virtual void BeginPrepare() {}
	public virtual bool PrepareRecord(LogRecord rec) {}
	public virtual bool EndPrepare() {}
	public virtual void BeginCommit(bool fRecovery) {}
	public virtual bool CommitRecord(LogRecord rec) {}
	public virtual void EndCommit() {}
	public virtual void BeginAbort(bool fRecovery) {}
	public virtual bool AbortRecord(LogRecord rec) {}
	public virtual void EndAbort() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Clerk Clerk { get{} }
}

