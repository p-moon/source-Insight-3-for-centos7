public class ContextMenu : Menu, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ContextMenu() {}
	public ContextMenu(MenuItem[] menuItems) {}

	// Methods
	public void Show(Control control, System.Drawing.Point pos) {}
	public void Show(Control control, System.Drawing.Point pos, LeftRightAlignment alignment) {}
	public MenuItem FindMenuItem(int type, System.IntPtr value) {}
	public ContextMenu GetContextMenu() {}
	public MainMenu GetMainMenu() {}
	public virtual void MergeMenu(Menu menuSrc) {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Control SourceControl { get{} }
	public RightToLeft RightToLeft { get{} set{} }
	public System.IntPtr Handle { get{} }
	public bool IsParent { get{} }
	public MenuItem MdiListItem { get{} }
	public string Name { get{} set{} }
	public MenuItemCollection MenuItems { get{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Popup;
	public event System.EventHandler Collapse;
	public event System.EventHandler Disposed;
}

