public class ManagementOperationObserver
{

	// Constructors
	public ManagementOperationObserver() {}

	// Methods
	public void Cancel() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.Management.ObjectReadyEventHandler ObjectReady;
	public event System.Management.CompletedEventHandler Completed;
	public event System.Management.ProgressEventHandler Progress;
	public event System.Management.ObjectPutEventHandler ObjectPut;
}

