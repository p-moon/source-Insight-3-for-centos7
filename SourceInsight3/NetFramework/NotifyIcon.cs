public class NotifyIcon : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public NotifyIcon() {}
	public NotifyIcon(System.ComponentModel.IContainer container) {}

	// Methods
	public void ShowBalloonTip(int timeout) {}
	public void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BalloonTipText { get{} set{} }
	public ToolTipIcon BalloonTipIcon { get{} set{} }
	public string BalloonTipTitle { get{} set{} }
	public ContextMenu ContextMenu { get{} set{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public System.Drawing.Icon Icon { get{} set{} }
	public string Text { get{} set{} }
	public bool Visible { get{} set{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler BalloonTipClicked;
	public event System.EventHandler BalloonTipClosed;
	public event System.EventHandler BalloonTipShown;
	public event System.EventHandler Click;
	public event System.EventHandler DoubleClick;
	public event System.Windows.Forms.MouseEventHandler MouseClick;
	public event System.Windows.Forms.MouseEventHandler MouseDoubleClick;
	public event System.Windows.Forms.MouseEventHandler MouseDown;
	public event System.Windows.Forms.MouseEventHandler MouseMove;
	public event System.Windows.Forms.MouseEventHandler MouseUp;
	public event System.EventHandler Disposed;
}

