public class ScrollableControlDesigner : ParentControlDesigner, System.ComponentModel.Design.ITreeDesigner, System.ComponentModel.Design.IDesigner, System.IDisposable, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IComponentInitializer, IOleDragClient
{

	// Constructors
	public ScrollableControlDesigner() {}

	// Methods
	public virtual bool CanParent(ControlDesigner controlDesigner) {}
	public virtual bool CanParent(System.Windows.Forms.Control control) {}
	public virtual System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) {}
	public virtual int NumberOfInternalControlDesigners() {}
	public virtual ControlDesigner InternalControlDesigner(int internalControlIndex) {}
	public virtual bool CanBeParentedTo(System.ComponentModel.Design.IDesigner parentDesigner) {}
	public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void OnSetComponentDefaults() {}
	public virtual void Dispose() {}
	public virtual void DoDefaultAction() {}
	public virtual void InitializeNonDefault() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IList SnapLines { get{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.Windows.Forms.AccessibleObject AccessibilityObject { get{} }
	public System.Windows.Forms.Control Control { get{} }
	public bool ParticipatesWithSnapLines { get{} }
	public bool AutoResizeHandles { get{} set{} }
	public SelectionRules SelectionRules { get{} }
	public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public System.ComponentModel.Design.DesignerVerbCollection Verbs { get{} }
}

