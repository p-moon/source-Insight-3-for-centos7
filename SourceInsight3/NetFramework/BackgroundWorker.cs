public class BackgroundWorker : Component, IComponent, System.IDisposable
{

	// Constructors
	public BackgroundWorker() {}

	// Methods
	public void CancelAsync() {}
	public void ReportProgress(int percentProgress) {}
	public void ReportProgress(int percentProgress, object userState) {}
	public void RunWorkerAsync() {}
	public void RunWorkerAsync(object argument) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CancellationPending { get{} }
	public bool IsBusy { get{} }
	public bool WorkerReportsProgress { get{} set{} }
	public bool WorkerSupportsCancellation { get{} set{} }
	public ISite Site { get{} set{} }
	public IContainer Container { get{} }

	// Events
	public event System.ComponentModel.DoWorkEventHandler DoWork;
	public event System.ComponentModel.ProgressChangedEventHandler ProgressChanged;
	public event System.ComponentModel.RunWorkerCompletedEventHandler RunWorkerCompleted;
	public event System.EventHandler Disposed;
}

