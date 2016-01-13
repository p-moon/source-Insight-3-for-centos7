public class TableItemStyle : Style, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IStateManager
{

	// Constructors
	public TableItemStyle() {}
	public TableItemStyle(System.Web.UI.StateBag bag) {}

	// Methods
	public virtual void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer, WebControl owner) {}
	public virtual void CopyFrom(Style s) {}
	public virtual void MergeWith(Style s) {}
	public virtual void Reset() {}
	public void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer) {}
	public System.Web.UI.CssStyleCollection GetStyleAttributes(System.Web.UI.IUrlResolutionService urlResolver) {}
	public void SetDirty() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HorizontalAlign HorizontalAlign { get{} set{} }
	public VerticalAlign VerticalAlign { get{} set{} }
	public bool Wrap { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public Unit BorderWidth { get{} set{} }
	public BorderStyle BorderStyle { get{} set{} }
	public string CssClass { get{} set{} }
	public FontInfo Font { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public Unit Height { get{} set{} }
	public bool IsEmpty { get{} }
	public string RegisteredCssClass { get{} }
	public Unit Width { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

