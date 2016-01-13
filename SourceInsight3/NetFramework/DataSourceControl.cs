public class DataSourceControl : Control, System.ComponentModel.IComponent, System.IDisposable, IParserAccessor, IUrlResolutionService, IDataBindingsAccessor, IControlBuilderAccessor, IControlDesignerAccessor, IExpressionsAccessor, IDataSource, System.ComponentModel.IListSource
{

	// Methods
	public virtual void ApplyStyleSheetSkin(Page page) {}
	public virtual Control FindControl(string id) {}
	public virtual void Focus() {}
	public virtual bool HasControls() {}
	public virtual void RenderControl(HtmlTextWriter writer) {}
	public virtual void DataBind() {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public void SetRenderMethodDelegate(RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ClientID { get{} }
	public ControlCollection Controls { get{} }
	public bool EnableTheming { get{} set{} }
	public string SkinID { get{} set{} }
	public bool Visible { get{} set{} }
	public string ID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public Control NamingContainer { get{} }
	public Control BindingContainer { get{} }
	public Page Page { get{} set{} }
	public TemplateControl TemplateControl { get{} set{} }
	public Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string UniqueID { get{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

