public class ControlDesigner : HtmlControlDesigner, System.ComponentModel.Design.ITreeDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IComponentInitializer
{

	// Constructors
	public ControlDesigner() {}

	// Methods
	public System.Drawing.Rectangle GetBounds() {}
	public virtual string GetDesignTimeHtml() {}
	public virtual string GetDesignTimeHtml(DesignerRegionCollection regions) {}
	public static DesignTimeResourceProviderFactory GetDesignTimeResourceProviderFactory(System.IServiceProvider serviceProvider) {}
	public virtual string GetEditableDesignerRegionContent(EditableDesignerRegion region) {}
	public virtual string GetPersistInnerHtml() {}
	public virtual string GetPersistenceContent() {}
	public void Localize(IDesignTimeResourceWriter resourceWriter) {}
	public static ViewRendering GetViewRendering(System.Web.UI.Control control) {}
	public static ViewRendering GetViewRendering(ControlDesigner designer) {}
	public ViewRendering GetViewRendering() {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle rectangle) {}
	public static void InvokeTransactedChange(System.ComponentModel.IComponent component, TransactedChangeCallback callback, object context, string description) {}
	public static void InvokeTransactedChange(System.ComponentModel.IComponent component, TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) {}
	public static void InvokeTransactedChange(System.IServiceProvider serviceProvider, System.ComponentModel.IComponent component, TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) {}
	public bool IsPropertyBound(string propName) {}
	public virtual void OnAutoFormatApplied(DesignerAutoFormat appliedAutoFormat) {}
	public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) {}
	public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) {}
	public void RaiseResizeEvent() {}
	public void RegisterClone(object original, object clone) {}
	public virtual void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content) {}
	public virtual void UpdateDesignTimeHtml() {}
	public virtual void OnSetParent() {}
	public virtual void Dispose() {}
	public virtual void DoDefaultAction() {}
	public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void InitializeNonDefault() {}
	public virtual void OnSetComponentDefaults() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get{} }
	public bool AllowResize { get{} }
	public DesignerAutoFormatCollection AutoFormats { get{} }
	public bool DesignTimeHtmlRequiresLoadComplete { get{} }
	public string ID { get{} set{} }
	public bool IsDirty { get{} set{} }
	public bool ViewControlCreated { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public TemplateGroupCollection TemplateGroups { get{} }
	public System.Web.UI.Control ViewControl { get{} set{} }
	public IHtmlControlDesignerBehavior Behavior { get{} set{} }
	public System.Web.UI.DataBindingCollection DataBindings { get{} }
	public System.Web.UI.ExpressionBindingCollection Expressions { get{} }
	public bool ShouldCodeSerialize { get{} set{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public System.ComponentModel.Design.DesignerVerbCollection Verbs { get{} }
}

