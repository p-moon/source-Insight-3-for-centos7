public class MainMenu : Menu, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public MainMenu() {}
	public MainMenu(System.ComponentModel.IContainer container) {}
	public MainMenu(MenuItem[] items) {}

	// Methods
	public virtual MainMenu CloneMenu() {}
	public Form GetForm() {}
	public virtual string ToString() {}
	public MenuItem FindMenuItem(int type, System.IntPtr value) {}
	public ContextMenu GetContextMenu() {}
	public MainMenu GetMainMenu() {}
	public virtual void MergeMenu(Menu menuSrc) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
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
	public event System.EventHandler Collapse;
	public event System.EventHandler Disposed;
}

