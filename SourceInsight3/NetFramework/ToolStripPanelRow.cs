public class ToolStripPanelRow : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.Windows.Forms.Layout.IArrangedElement
{

	// Constructors
	public ToolStripPanelRow(ToolStripPanel parent) {}

	// Methods
	public bool CanMove(ToolStrip toolStripToDrag) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Rectangle Bounds { get{} }
	public Control[] Controls { get{} }
	public System.Drawing.Rectangle DisplayRectangle { get{} }
	public System.Windows.Forms.Layout.LayoutEngine LayoutEngine { get{} }
	public Padding Margin { get{} set{} }
	public Padding Padding { get{} set{} }
	public ToolStripPanel ToolStripPanel { get{} }
	public Orientation Orientation { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

