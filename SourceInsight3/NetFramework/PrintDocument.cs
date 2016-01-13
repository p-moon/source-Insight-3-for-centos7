public class PrintDocument : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public PrintDocument() {}

	// Methods
	public void Print() {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PageSettings DefaultPageSettings { get{} set{} }
	public string DocumentName { get{} set{} }
	public bool OriginAtMargins { get{} set{} }
	public PrintController PrintController { get{} set{} }
	public PrinterSettings PrinterSettings { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Drawing.Printing.PrintEventHandler BeginPrint;
	public event System.Drawing.Printing.PrintEventHandler EndPrint;
	public event System.Drawing.Printing.PrintPageEventHandler PrintPage;
	public event System.Drawing.Printing.QueryPageSettingsEventHandler QueryPageSettings;
	public event System.EventHandler Disposed;
}

