public class TemplatedControlDesigner : ControlDesigner, System.ComponentModel.Design.ITreeDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IComponentInitializer
{

	// Constructors
	public TemplatedControlDesigner() {}

	// Methods
	public void EnterTemplateMode(ITemplateEditingFrame newTemplateEditingFrame) {}
	public void ExitTemplateMode(bool fSwitchingTemplates, bool fNested, bool fSave) {}
	public virtual string GetTemplateContainerDataItemProperty(string templateName) {}
	public virtual System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) {}
	public abstract virtual string GetTemplateContent(ITemplateEditingFrame editingFrame, string templateNameout , System.Boolean& allowEditing) {}
	public TemplateEditingVerb[] GetTemplateEditingVerbs() {}
	public virtual Type GetTemplatePropertyParentType(string templateName) {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) {}
	public virtual void OnSetParent() {}
	public abstract virtual void SetTemplateContent(ITemplateEditingFrame editingFrame, string templateName, string templateContent) {}
	public virtual void UpdateDesignTimeHtml() {}
	public System.Drawing.Rectangle GetBounds() {}
	public virtual string GetDesignTimeHtml() {}
	public virtual string GetDesignTimeHtml(DesignerRegionCollection regions) {}
	public virtual string GetEditableDesignerRegionContent(EditableDesignerRegion region) {}
	public virtual string GetPersistInnerHtml() {}
	public virtual string GetPersistenceContent() {}
	public void Localize(IDesignTimeResourceWriter resourceWriter) {}
	public ViewRendering GetViewRendering() {}
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle rectangle) {}
	public bool IsPropertyBound(string propName) {}
	public virtual void OnAutoFormatApplied(DesignerAutoFormat appliedAutoFormat) {}
	public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) {}
	public void RaiseResizeEvent() {}
	public void RegisterClone(object original, object clone) {}
	public virtual void SetEditableDesignerRegionContent(EditableDesignerRegion region, string content) {}
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
	public ITemplateEditingFrame ActiveTemplateEditingFrame { get{} }
	public bool CanEnterTemplateMode { get{} }
	public bool InTemplateMode { get{} }
	public TemplateGroupCollection TemplateGroups { get{} }
	public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get{} }
	public bool AllowResize { get{} }
	public DesignerAutoFormatCollection AutoFormats { get{} }
	public bool DesignTimeHtmlRequiresLoadComplete { get{} }
	public string ID { get{} set{} }
	public bool IsDirty { get{} set{} }
	public bool ViewControlCreated { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public System.Web.UI.Control ViewControl { get{} set{} }
	public IHtmlControlDesignerBehavior Behavior { get{} set{} }
	public System.Web.UI.DataBindingCollection DataBindings { get{} }
	public System.Web.UI.ExpressionBindingCollection Expressions { get{} }
	public bool ShouldCodeSerialize { get{} set{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public System.ComponentModel.Design.DesignerVerbCollection Verbs { get{} }
}

