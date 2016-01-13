public class ComponentDesigner : ITreeDesigner, IDesigner, System.IDisposable, IDesignerFilter, IComponentInitializer
{

	// Constructors
	public ComponentDesigner() {}

	// Methods
	public virtual void Dispose() {}
	public virtual void DoDefaultAction() {}
	public virtual void Initialize(System.ComponentModel.IComponent component) {}
	public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) {}
	public virtual void InitializeNonDefault() {}
	public virtual void OnSetComponentDefaults() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerActionListCollection ActionLists { get{} }
	public System.Collections.ICollection AssociatedComponents { get{} }
	public System.ComponentModel.IComponent Component { get{} }
	public DesignerVerbCollection Verbs { get{} }
}

