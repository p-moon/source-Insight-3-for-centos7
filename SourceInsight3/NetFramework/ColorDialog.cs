public class ColorDialog : CommonDialog, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ColorDialog() {}

	// Methods
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
	public bool AllowFullOpen { get{} set{} }
	public bool AnyColor { get{} set{} }
	public System.Drawing.Color Color { get{} set{} }
	public int[] CustomColors { get{} set{} }
	public bool FullOpen { get{} set{} }
	public bool ShowHelp { get{} set{} }
	public bool SolidColorOnly { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler HelpRequest;
	public event System.EventHandler Disposed;
}

