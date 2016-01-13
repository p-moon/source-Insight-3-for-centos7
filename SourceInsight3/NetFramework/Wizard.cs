public class Wizard : CompositeControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, ICompositeControlDesignerAccessor
{

	// Constructors
	public Wizard() {}

	// Methods
	public System.Collections.ICollection GetHistory() {}
	public WizardStepType GetStepType(WizardStepBase wizardStep, int index) {}
	public void MoveTo(WizardStepBase wizardStep) {}
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
	public string CancelCommandName;
	public string MoveNextCommandName;
	public string MovePreviousCommandName;
	public string MoveToCommandName;
	public string MoveCompleteCommandName;

	// Properties
	public WizardStepBase ActiveStep { get{} }
	public int ActiveStepIndex { get{} set{} }
	public string CancelButtonImageUrl { get{} set{} }
	public Style CancelButtonStyle { get{} }
	public string CancelButtonText { get{} set{} }
	public ButtonType CancelButtonType { get{} set{} }
	public string CancelDestinationPageUrl { get{} set{} }
	public int CellPadding { get{} set{} }
	public int CellSpacing { get{} set{} }
	public bool DisplayCancelButton { get{} set{} }
	public Style FinishCompleteButtonStyle { get{} }
	public string FinishCompleteButtonText { get{} set{} }
	public ButtonType FinishCompleteButtonType { get{} set{} }
	public string FinishDestinationPageUrl { get{} set{} }
	public string FinishCompleteButtonImageUrl { get{} set{} }
	public Style FinishPreviousButtonStyle { get{} }
	public string FinishPreviousButtonText { get{} set{} }
	public ButtonType FinishPreviousButtonType { get{} set{} }
	public string FinishPreviousButtonImageUrl { get{} set{} }
	public Style StartNextButtonStyle { get{} }
	public string StartNextButtonText { get{} set{} }
	public ButtonType StartNextButtonType { get{} set{} }
	public string StartNextButtonImageUrl { get{} set{} }
	public System.Web.UI.ITemplate FinishNavigationTemplate { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public System.Web.UI.ITemplate HeaderTemplate { get{} set{} }
	public string HeaderText { get{} set{} }
	public Style NavigationButtonStyle { get{} }
	public TableItemStyle NavigationStyle { get{} }
	public Style StepNextButtonStyle { get{} }
	public string StepNextButtonText { get{} set{} }
	public ButtonType StepNextButtonType { get{} set{} }
	public string StepNextButtonImageUrl { get{} set{} }
	public Style StepPreviousButtonStyle { get{} }
	public string StepPreviousButtonText { get{} set{} }
	public ButtonType StepPreviousButtonType { get{} set{} }
	public string StepPreviousButtonImageUrl { get{} set{} }
	public Style SideBarButtonStyle { get{} }
	public bool DisplaySideBar { get{} set{} }
	public TableItemStyle SideBarStyle { get{} }
	public System.Web.UI.ITemplate SideBarTemplate { get{} set{} }
	public string SkipLinkText { get{} set{} }
	public System.Web.UI.ITemplate StartNavigationTemplate { get{} set{} }
	public System.Web.UI.ITemplate StepNavigationTemplate { get{} set{} }
	public TableItemStyle StepStyle { get{} }
	public WizardStepCollection WizardSteps { get{} }
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
	public event System.EventHandler ActiveStepChanged;
	public event System.EventHandler CancelButtonClick;
	public event System.Web.UI.WebControls.WizardNavigationEventHandler FinishButtonClick;
	public event System.Web.UI.WebControls.WizardNavigationEventHandler NextButtonClick;
	public event System.Web.UI.WebControls.WizardNavigationEventHandler PreviousButtonClick;
	public event System.Web.UI.WebControls.WizardNavigationEventHandler SideBarButtonClick;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

