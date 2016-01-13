public class SaveFileDialog : FileDialog, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public SaveFileDialog() {}

	// Methods
	public System.IO.Stream OpenFile() {}
	public virtual void Reset() {}
	public virtual string ToString() {}
	public DialogResult ShowDialog() {}
	public DialogResult ShowDialog(IWin32Window owner) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CreatePrompt { get{} set{} }
	public bool OverwritePrompt { get{} set{} }
	public bool AddExtension { get{} set{} }
	public bool CheckFileExists { get{} set{} }
	public bool CheckPathExists { get{} set{} }
	public string DefaultExt { get{} set{} }
	public bool DereferenceLinks { get{} set{} }
	public string FileName { get{} set{} }
	public string[] FileNames { get{} }
	public string Filter { get{} set{} }
	public int FilterIndex { get{} set{} }
	public string InitialDirectory { get{} set{} }
	public bool RestoreDirectory { get{} set{} }
	public bool ShowHelp { get{} set{} }
	public bool SupportMultiDottedExtensions { get{} set{} }
	public string Title { get{} set{} }
	public bool ValidateNames { get{} set{} }
	public FileDialogCustomPlacesCollection CustomPlaces { get{} }
	public bool AutoUpgradeEnabled { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.ComponentModel.CancelEventHandler FileOk;
	public event System.EventHandler HelpRequest;
	public event System.EventHandler Disposed;
}

