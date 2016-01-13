public class StatusBarPanel : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public StatusBarPanel() {}

	// Methods
	public virtual void BeginInit() {}
	public virtual void EndInit() {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HorizontalAlignment Alignment { get{} set{} }
	public StatusBarPanelAutoSize AutoSize { get{} set{} }
	public StatusBarPanelBorderStyle BorderStyle { get{} set{} }
	public System.Drawing.Icon Icon { get{} set{} }
	public int MinWidth { get{} set{} }
	public string Name { get{} set{} }
	public StatusBar Parent { get{} }
	public StatusBarPanelStyle Style { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public string ToolTipText { get{} set{} }
	public int Width { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

