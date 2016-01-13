public class ColumnHeader : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ICloneable
{

	// Constructors
	public ColumnHeader() {}
	public ColumnHeader(int imageIndex) {}
	public ColumnHeader(string imageKey) {}

	// Methods
	public void AutoResize(ColumnHeaderAutoResizeStyle headerAutoResize) {}
	public virtual object Clone() {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int DisplayIndex { get{} set{} }
	public int Index { get{} }
	public int ImageIndex { get{} set{} }
	public ImageList ImageList { get{} }
	public string ImageKey { get{} set{} }
	public ListView ListView { get{} }
	public string Name { get{} set{} }
	public string Text { get{} set{} }
	public HorizontalAlignment TextAlign { get{} set{} }
	public object Tag { get{} set{} }
	public int Width { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

