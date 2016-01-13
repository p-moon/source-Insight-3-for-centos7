public class ToolStripMenuItemArray : BaseControlArray, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public ToolStripMenuItemArray() {}
	public ToolStripMenuItemArray(System.ComponentModel.IContainer Container) {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public short GetIndex(System.Windows.Forms.ToolStripMenuItem o) {}
	public void SetIndex(System.Windows.Forms.ToolStripMenuItem o, short Index) {}
	public bool ShouldSerializeIndex(System.Windows.Forms.ToolStripMenuItem o) {}
	public void ResetIndex(System.Windows.Forms.ToolStripMenuItem o) {}
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
	public System.Windows.Forms.ToolStripMenuItem Item { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler CheckedChanged;
	public event System.EventHandler CheckStateChanged;
	public event System.EventHandler Click;
	public event System.EventHandler DisplayStyleChanged;
	public event System.EventHandler DoubleClick;
	public event System.EventHandler DropDownClosed;
	public event System.Windows.Forms.ToolStripItemClickedEventHandler DropDownItemClicked;
	public event System.EventHandler DropDownOpened;
	public event System.EventHandler DropDownOpening;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.EventHandler LocationChanged;
	public event System.Windows.Forms.MouseEventHandler MouseDown;
	public event System.EventHandler MouseEnter;
	public event System.EventHandler MouseHover;
	public event System.EventHandler MouseLeave;
	public event System.Windows.Forms.MouseEventHandler MouseMove;
	public event System.Windows.Forms.MouseEventHandler MouseUp;
	public event System.EventHandler OwnerChanged;
	public event System.Windows.Forms.PaintEventHandler Paint;
	public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler TextChanged;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Disposed;
}

