public class ImageList : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public ImageList() {}
	public ImageList(System.ComponentModel.IContainer container) {}

	// Methods
	public void Draw(System.Drawing.Graphics g, System.Drawing.Point pt, int index) {}
	public void Draw(System.Drawing.Graphics g, int x, int y, int index) {}
	public void Draw(System.Drawing.Graphics g, int x, int y, int width, int height, int index) {}
	public virtual string ToString() {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ColorDepth ColorDepth { get{} set{} }
	public System.IntPtr Handle { get{} }
	public bool HandleCreated { get{} }
	public ImageCollection Images { get{} }
	public System.Drawing.Size ImageSize { get{} set{} }
	public ImageListStreamer ImageStream { get{} set{} }
	public object Tag { get{} set{} }
	public System.Drawing.Color TransparentColor { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler RecreateHandle;
	public event System.EventHandler Disposed;
}

