public class DataListDesigner : BaseDataListDesigner, System.ComponentModel.Design.ITreeDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IComponentInitializer, System.Web.UI.Design.IDataBindingSchemaProvider, System.Web.UI.Design.IDataSourceProvider
{

	// Constructors
	public DataListDesigner() {}

	// Methods
	public virtual string GetDesignTimeHtml() {}
	public virtual string GetTemplateContainerDataItemProperty(string templateName) {}
	public virtual string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateNameout , System.Boolean& allowEditing) {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public virtual void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent) {}
	public virtual System.Collections.IEnumerable GetResolvedSelectedDataSource() {}
	public virtual object GetSelectedDataSource() {}
	public virtual System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) {}
	public virtual void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) {}
	public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) {}
	public void EnterTemplateMode(System.Web.UI.Design.ITemplateEditingFrame newTemplateEditingFrame) {}
	public void ExitTemplateMode(bool fSwitchingTemplates, bool fNested, bool fSave) {}
	public System.Web.UI.Design.TemplateEditingVerb[] GetTemplateEditingVerbs() {}
	public virtual Type GetTemplatePropertyParentType(string templateName) {}
	public virtual void OnSetParent() {}
	public virtual void UpdateDesignTimeHtml() {}
	public System.Drawing.Rectangle GetBounds() {}
	public virtual string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) {}
	public virtual string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) {}
	public virtual string GetPersistInnerHtml() {}
	public virtual string GetPersistenceContent() {}
	public void Localize(System.Web.UI.Design.IDesignTimeResourceWriter resourceWriter) {}
	public System.Web.UI.Design.ViewRendering GetViewRendering() {}
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle rectangle) {}
	public bool IsPropertyBound(string propName) {}
	public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) {}
	public void RaiseResizeEvent() {}
	public void RegisterClone(object original, object clone) {}
	public virtual void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) {}
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
	public bool AllowResize { get{} }
	public System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get{} }
	public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get{} }
	public string DataKeyField { get{} set{} }
	public string DataMember { get{} set{} }
	public string DataSource { get{} set{} }
	public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get{} }
	public string DataSourceID { get{} set{} }
	public System.Web.UI.Design.DesignerDataSourceView DesignerView { get{} }
	public System.Web.UI.Design.ITemplateEditingFrame ActiveTemplateEditingFrame { get{} }
	public bool CanEnterTemplateMode { get{} }
	public bool InTemplateMode { get{} }
	public System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get{} }
	public bool DesignTimeHtmlRequiresLoadComplete { get{} }
	public string ID { get{} set{} }
	public bool IsDirty { get{} set{} }
	public bool ViewControlCreated { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public System.Web.UI.Control ViewControl { get{} set{} }
	public System.Web.UI.Design.IHtmlControlDesignerBehavior Behavior { get{} set{} }
	public System.Web.UI.DataBindingCollection DataBindings { get{} }
	public System.Web.UI.ExpressionBindingCollection Expressions { get{} }
	public bool ShouldCodeSerialize { get{} set{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public System.ComponentModel.Design.DesignerVerbCollection Verbs { get{} }
}

