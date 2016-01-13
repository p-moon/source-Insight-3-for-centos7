public interface IRunnableObject
{

	// Methods
	public abstract virtual void GetRunningClass(out System.Guid& guid) {}
	public abstract virtual int Run(System.IntPtr lpBindContext) {}
	public abstract virtual bool IsRunning() {}
	public abstract virtual void LockRunning(bool fLock, bool fLastUnlockCloses) {}
	public abstract virtual void SetContainedObject(bool fContained) {}
}

