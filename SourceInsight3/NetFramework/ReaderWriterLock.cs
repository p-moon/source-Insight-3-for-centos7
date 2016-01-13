public class ReaderWriterLock : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
{

	// Constructors
	public ReaderWriterLock() {}

	// Methods
	public bool AnyWritersSince(int seqNum) {}
	public void ReleaseReaderLock() {}
	public void ReleaseWriterLock() {}
	public void AcquireReaderLock(int millisecondsTimeout) {}
	public void AcquireReaderLock(System.TimeSpan timeout) {}
	public void AcquireWriterLock(int millisecondsTimeout) {}
	public void AcquireWriterLock(System.TimeSpan timeout) {}
	public LockCookie UpgradeToWriterLock(int millisecondsTimeout) {}
	public LockCookie UpgradeToWriterLock(System.TimeSpan timeout) {}
	public void DowngradeFromWriterLock(LockCookie& lockCookie) {}
	public LockCookie ReleaseLock() {}
	public void RestoreLock(LockCookie& lockCookie) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsReaderLockHeld { get{} }
	public bool IsWriterLockHeld { get{} }
	public int WriterSeqNum { get{} }
}

