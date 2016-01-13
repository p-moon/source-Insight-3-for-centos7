public class MenuItem : Menu, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public MenuItem() {}
	public MenuItem(string text) {}
	public MenuItem(string text, System.EventHandler onClick) {}
	public MenuItem(string text, System.EventHandler onClick, Shortcut shortcut) {}
	public MenuItem(string text, MenuItem[] items) {}
	public MenuItem(MenuMerge mergeType, int mergeOrder, Shortcut shortcut, string text, System.EventHandler onClick, System.EventHandler onPopup, System.EventHandler onSelect, MenuItem[] items) {}

	// Methods
	public virtual MenuItem CloneMenu() {}
	public virtual MenuItem MergeMenu() {}
	public void MergeMenu(MenuItem itemSrc) {}
	public void PerformClick() {}
	public virtual void PerformSelect() {}
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
	public bool BarBreak { get{} set{} }
	public bool Break { get{} set{} }
	public bool Checked { get{} set{} }
	public bool DefaultItem { get{} set{} }
	public bool OwnerDraw { get{} set{} }
	public bool Enabled { get{} set{} }
	public int Index { get{} set{} }
	public bool IsParent { get{} }
	public bool MdiList { get{} set{} }
	public MenuMerge MergeType { get{} set{} }
	public int MergeOrder { get{} set{} }
	public char Mnemonic { get{} }
	public Menu Parent { get{} }
	public bool RadioCheck { get{} set{} }
	public string Text { get{} set{} }
	public Shortcut Shortcut { get{} set{} }
	public bool ShowShortcut { get{} set{} }
	public bool Visible { get{} set{} }
	public System.IntPtr Handle { get{} }
	public MenuItem MdiListItem { get{} }
	public string Name { get{} set{} }
	public MenuItemCollection MenuItems { get{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Click;
	public event System.Windows.Forms.DrawItemEventHandler DrawItem;
	public event System.Windows.Forms.MeasureItemEventHandler MeasureItem;
	public event System.EventHandler Popup;
	public event System.EventHandler Select;
	public event System.EventHandler Disposed;
}

