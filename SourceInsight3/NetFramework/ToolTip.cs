public class ToolTip : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public ToolTip(System.ComponentModel.IContainer cont) {}
	public ToolTip() {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public string GetToolTip(Control control) {}
	public void RemoveAll() {}
	public void SetToolTip(Control control, string caption) {}
	public void Show(string text, IWin32Window window) {}
	public void Show(string text, IWin32Window window, int duration) {}
	public void Show(string text, IWin32Window window, System.Drawing.Point point) {}
	public void Show(string text, IWin32Window window, System.Drawing.Point point, int duration) {}
	public void Show(string text, IWin32Window window, int x, int y) {}
	public void Show(string text, IWin32Window window, int x, int y, int duration) {}
	public void Hide(IWin32Window win) {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Active { get{} set{} }
	public int AutomaticDelay { get{} set{} }
	public int AutoPopDelay { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public bool IsBalloon { get{} set{} }
	public int InitialDelay { get{} set{} }
	public bool OwnerDraw { get{} set{} }
	public int ReshowDelay { get{} set{} }
	public bool ShowAlways { get{} set{} }
	public bool StripAmpersands { get{} set{} }
	public object Tag { get{} set{} }
	public ToolTipIcon ToolTipIcon { get{} set{} }
	public string ToolTipTitle { get{} set{} }
	public bool UseAnimation { get{} set{} }
	public bool UseFading { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Windows.Forms.DrawToolTipEventHandler Draw;
	public event System.Windows.Forms.PopupEventHandler Popup;
	public event System.EventHandler Disposed;
}

