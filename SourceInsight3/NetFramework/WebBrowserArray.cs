public class WebBrowserArray : BaseControlArray, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public WebBrowserArray() {}
	public WebBrowserArray(System.ComponentModel.IContainer Container) {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public short GetIndex(System.Windows.Forms.WebBrowser o) {}
	public void SetIndex(System.Windows.Forms.WebBrowser o, short Index) {}
	public bool ShouldSerializeIndex(System.Windows.Forms.WebBrowser o) {}
	public void ResetIndex(System.Windows.Forms.WebBrowser o) {}
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
	public System.Windows.Forms.WebBrowser Item { get{} }
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
	public event System.Windows.Forms.WebBrowserDocumentCompletedEventHandler DocumentCompleted;
	public event System.EventHandler FileDownload;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler Move;
	public event System.Windows.Forms.WebBrowserNavigatedEventHandler Navigated;
	public event System.Windows.Forms.WebBrowserNavigatingEventHandler Navigating;
	public event System.ComponentModel.CancelEventHandler NewWindow;
	public event System.EventHandler ParentChanged;
	public event System.Windows.Forms.WebBrowserProgressChangedEventHandler ProgressChanged;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler Resize;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler SystemColorsChanged;
	public event System.EventHandler Validated;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Disposed;
}

