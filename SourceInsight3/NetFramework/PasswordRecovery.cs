public class PasswordRecovery : CompositeControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, ICompositeControlDesignerAccessor
{

	// Constructors
	public PasswordRecovery() {}

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
	public string SubmitButtonCommandName;

	// Properties
	public string Answer { get{} }
	public string AnswerLabelText { get{} set{} }
	public string AnswerRequiredErrorMessage { get{} set{} }
	public int BorderPadding { get{} set{} }
	public Style SubmitButtonStyle { get{} }
	public ButtonType SubmitButtonType { get{} set{} }
	public TableItemStyle FailureTextStyle { get{} }
	public string GeneralFailureText { get{} set{} }
	public string HelpPageText { get{} set{} }
	public string HelpPageIconUrl { get{} set{} }
	public string HelpPageUrl { get{} set{} }
	public TableItemStyle HyperLinkStyle { get{} }
	public TableItemStyle InstructionTextStyle { get{} }
	public TableItemStyle LabelStyle { get{} }
	public MailDefinition MailDefinition { get{} }
	public string MembershipProvider { get{} set{} }
	public string Question { get{} set{} }
	public string QuestionFailureText { get{} set{} }
	public string QuestionInstructionText { get{} set{} }
	public string QuestionLabelText { get{} set{} }
	public string QuestionTitleText { get{} set{} }
	public System.Web.UI.ITemplate QuestionTemplate { get{} set{} }
	public System.Web.UI.Control QuestionTemplateContainer { get{} }
	public string SubmitButtonImageUrl { get{} set{} }
	public string SubmitButtonText { get{} set{} }
	public string SuccessPageUrl { get{} set{} }
	public System.Web.UI.ITemplate SuccessTemplate { get{} set{} }
	public System.Web.UI.Control SuccessTemplateContainer { get{} }
	public string SuccessText { get{} set{} }
	public TableItemStyle SuccessTextStyle { get{} }
	public Style TextBoxStyle { get{} }
	public LoginTextLayout TextLayout { get{} set{} }
	public TableItemStyle TitleTextStyle { get{} }
	public string UserName { get{} set{} }
	public string UserNameFailureText { get{} set{} }
	public string UserNameInstructionText { get{} set{} }
	public string UserNameLabelText { get{} set{} }
	public string UserNameRequiredErrorMessage { get{} set{} }
	public System.Web.UI.ITemplate UserNameTemplate { get{} set{} }
	public System.Web.UI.Control UserNameTemplateContainer { get{} }
	public string UserNameTitleText { get{} set{} }
	public Style ValidatorTextStyle { get{} }
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
	public event System.EventHandler AnswerLookupError;
	public event System.Web.UI.WebControls.LoginCancelEventHandler VerifyingAnswer;
	public event System.Web.UI.WebControls.MailMessageEventHandler SendingMail;
	public event System.Web.UI.WebControls.SendMailErrorEventHandler SendMailError;
	public event System.Web.UI.WebControls.LoginCancelEventHandler VerifyingUser;
	public event System.EventHandler UserLookupError;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

