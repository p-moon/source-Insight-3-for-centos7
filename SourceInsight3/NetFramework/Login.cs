public class Login : CompositeControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, ICompositeControlDesignerAccessor
{

	// Constructors
	public Login() {}

	// Methods
	public virtual void DataBind() {}
	public void ApplyStyle(Style s) {}
	public void CopyBaseAttributes(WebControl controlSrc) {}
	public void MergeStyle(Style s) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
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

	// Fields
	public string LoginButtonCommandName;

	// Properties
	public int BorderPadding { get{} set{} }
	public TableItemStyle CheckBoxStyle { get{} }
	public string CreateUserText { get{} set{} }
	public string CreateUserUrl { get{} set{} }
	public string DestinationPageUrl { get{} set{} }
	public bool DisplayRememberMe { get{} set{} }
	public string HelpPageText { get{} set{} }
	public string HelpPageUrl { get{} set{} }
	public string CreateUserIconUrl { get{} set{} }
	public string HelpPageIconUrl { get{} set{} }
	public TableItemStyle HyperLinkStyle { get{} }
	public string InstructionText { get{} set{} }
	public TableItemStyle InstructionTextStyle { get{} }
	public TableItemStyle LabelStyle { get{} }
	public System.Web.UI.ITemplate LayoutTemplate { get{} set{} }
	public LoginFailureAction FailureAction { get{} set{} }
	public string FailureText { get{} set{} }
	public TableItemStyle FailureTextStyle { get{} }
	public string LoginButtonImageUrl { get{} set{} }
	public Style LoginButtonStyle { get{} }
	public string LoginButtonText { get{} set{} }
	public ButtonType LoginButtonType { get{} set{} }
	public Orientation Orientation { get{} set{} }
	public string MembershipProvider { get{} set{} }
	public string Password { get{} }
	public string PasswordLabelText { get{} set{} }
	public string PasswordRecoveryText { get{} set{} }
	public string PasswordRecoveryUrl { get{} set{} }
	public string PasswordRecoveryIconUrl { get{} set{} }
	public string PasswordRequiredErrorMessage { get{} set{} }
	public bool RememberMeSet { get{} set{} }
	public string RememberMeText { get{} set{} }
	public Style TextBoxStyle { get{} }
	public LoginTextLayout TextLayout { get{} set{} }
	public string TitleText { get{} set{} }
	public TableItemStyle TitleTextStyle { get{} }
	public string UserName { get{} set{} }
	public string UserNameLabelText { get{} set{} }
	public string UserNameRequiredErrorMessage { get{} set{} }
	public Style ValidatorTextStyle { get{} }
	public bool VisibleWhenLoggedIn { get{} set{} }
	public System.Web.UI.ControlCollection Controls { get{} }
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
	public bool Enabled { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public FontInfo Font { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
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

	// Events
	public event System.EventHandler LoggedIn;
	public event System.Web.UI.WebControls.AuthenticateEventHandler Authenticate;
	public event System.Web.UI.WebControls.LoginCancelEventHandler LoggingIn;
	public event System.EventHandler LoginError;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

