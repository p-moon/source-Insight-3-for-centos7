public class BaseOcxArray : BaseControlArray, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize
{

	// Methods
	public void Load(short Index) {}
	public void Unload(short Index) {}
	public short LBound() {}
	public short UBound() {}
	public short Count() {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler CausesValidationChanged;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.EventHandler DockChanged;
	public event System.EventHandler Enter;
	public event System.EventHandler Leave;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler MouseCaptureChanged;
	public event System.EventHandler Move;
	public event System.EventHandler PaddingChanged;
	public event System.EventHandler ParentChanged;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler Resize;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler SystemColorsChanged;
	public event System.EventHandler Validated;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Disposed;
}

