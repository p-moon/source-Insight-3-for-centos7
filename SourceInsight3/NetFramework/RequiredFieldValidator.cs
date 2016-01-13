public class RequiredFieldValidator : BaseValidator, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.ITextControl, System.Web.UI.IValidator
{

	// Constructors
	public RequiredFieldValidator() {}

	// Methods
	public virtual void Validate() {}
	public void ApplyStyle(Style s) {}
	public void CopyBaseAttributes(WebControl controlSrc) {}
	public void MergeStyle(Style s) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual void DataBind() {}
	public virtual void Focus() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string InitialValue { get{} set{} }
	public string AssociatedControlID { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public string ControlToValidate { get{} set{} }
	public string ErrorMessage { get{} set{} }
	public bool EnableClientScript { get{} set{} }
	public bool Enabled { get{} set{} }
	public bool IsValid { get{} set{} }
	public ValidatorDisplay Display { get{} set{} }
	public bool SetFocusOnError { get{} set{} }
	public string Text { get{} set{} }
	public string ValidationGroup { get{} set{} }
	public string AccessKey { get{} set{} }
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public Unit BorderWidth { get{} set{} }
	public BorderStyle BorderStyle { get{} set{} }
	public Style ControlStyle { get{} }
	public bool ControlStyleCreated { get{} }
	public string CssClass { get{} set{} }
	public System.Web.UI.CssStyleCollection Style { get{} }
	public bool EnableTheming { get{} set{} }
	public FontInfo Font { get{} }
	public bool HasAttributes { get{} }
	public Unit Height { get{} set{} }
	public string SkinID { get{} set{} }
	public short TabIndex { get{} set{} }
	public string ToolTip { get{} set{} }
	public Unit Width { get{} set{} }
	public string ClientID { get{} }
	public string ID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public bool Visible { get{} set{} }
	public string UniqueID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

