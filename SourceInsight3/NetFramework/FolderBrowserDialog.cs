public class FolderBrowserDialog : CommonDialog, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public FolderBrowserDialog() {}

	// Methods
	public virtual void Reset() {}
	public DialogResult ShowDialog() {}
	public DialogResult ShowDialog(IWin32Window owner) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ShowNewFolderButton { get{} set{} }
	public string SelectedPath { get{} set{} }
	public System.Environment.SpecialFolder RootFolder { get{} set{} }
	public string Description { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler HelpRequest;
	public event System.EventHandler Disposed;
}

