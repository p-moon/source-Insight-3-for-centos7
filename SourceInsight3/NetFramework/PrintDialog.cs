public class PrintDialog : CommonDialog, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public PrintDialog() {}

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
	public bool AllowCurrentPage { get{} set{} }
	public bool AllowSomePages { get{} set{} }
	public bool AllowPrintToFile { get{} set{} }
	public bool AllowSelection { get{} set{} }
	public System.Drawing.Printing.PrintDocument Document { get{} set{} }
	public System.Drawing.Printing.PrinterSettings PrinterSettings { get{} set{} }
	public bool PrintToFile { get{} set{} }
	public bool ShowHelp { get{} set{} }
	public bool ShowNetwork { get{} set{} }
	public bool UseEXDialog { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler HelpRequest;
	public event System.EventHandler Disposed;
}

