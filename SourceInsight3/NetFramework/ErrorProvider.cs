public class ErrorProvider : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.IExtenderProvider, System.ComponentModel.ISupportInitialize
{

	// Constructors
	public ErrorProvider() {}
	public ErrorProvider(ContainerControl parentControl) {}
	public ErrorProvider(System.ComponentModel.IContainer container) {}

	// Methods
	public void BindToDataAndErrors(object newDataSource, string newDataMember) {}
	public void UpdateBinding() {}
	public void Clear() {}
	public virtual bool CanExtend(object extendee) {}
	public string GetError(Control control) {}
	public ErrorIconAlignment GetIconAlignment(Control control) {}
	public int GetIconPadding(Control control) {}
	public void SetError(Control control, string value) {}
	public void SetIconAlignment(Control control, ErrorIconAlignment value) {}
	public void SetIconPadding(Control control, int padding) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.ISite Site { set{} }
	public ErrorBlinkStyle BlinkStyle { get{} set{} }
	public ContainerControl ContainerControl { get{} set{} }
	public bool RightToLeft { get{} set{} }
	public object Tag { get{} set{} }
	public object DataSource { get{} set{} }
	public string DataMember { get{} set{} }
	public int BlinkRate { get{} set{} }
	public System.Drawing.Icon Icon { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler Disposed;
}

