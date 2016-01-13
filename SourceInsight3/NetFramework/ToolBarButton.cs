public class ToolBarButton : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ToolBarButton() {}
	public ToolBarButton(string text) {}

	// Methods
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Menu DropDownMenu { get{} set{} }
	public bool Enabled { get{} set{} }
	public int ImageIndex { get{} set{} }
	public string ImageKey { get{} set{} }
	public string Name { get{} set{} }
	public ToolBar Parent { get{} }
	public bool PartialPush { get{} set{} }
	public bool Pushed { get{} set{} }
	public System.Drawing.Rectangle Rectangle { get{} }
	public ToolBarButtonStyle Style { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public string ToolTipText { get{} set{} }
	public bool Visible { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

