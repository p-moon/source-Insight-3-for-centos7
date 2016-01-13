public class WebPartPersonalization
{

	// Constructors
	public WebPartPersonalization(WebPartManager owner) {}

	// Methods
	public void EnsureEnabled(bool ensureModifiable) {}
	public virtual void ResetPersonalizationState() {}
	public virtual void ToggleScope() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public WebPartUserCapability ModifyStateUserCapability;
	public WebPartUserCapability EnterSharedScopeUserCapability;

	// Properties
	public bool CanEnterSharedScope { get{} }
	public bool Enabled { get{} set{} }
	public bool HasPersonalizationState { get{} }
	public PersonalizationScope InitialScope { get{} set{} }
	public bool IsEnabled { get{} }
	public bool IsModifiable { get{} }
	public string ProviderName { get{} set{} }
	public PersonalizationScope Scope { get{} }
}

