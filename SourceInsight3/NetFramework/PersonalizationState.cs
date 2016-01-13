public class PersonalizationState
{

	// Methods
	public abstract virtual void ApplyWebPartPersonalization(WebPart webPart) {}
	public abstract virtual void ApplyWebPartManagerPersonalization() {}
	public abstract virtual void ExtractWebPartPersonalization(WebPart webPart) {}
	public abstract virtual void ExtractWebPartManagerPersonalization() {}
	public abstract virtual string GetAuthorizationFilter(string webPartID) {}
	public abstract virtual void SetWebPartDirty(WebPart webPart) {}
	public abstract virtual void SetWebPartManagerDirty() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsDirty { get{} }
	public bool IsEmpty { get{} }
	public WebPartManager WebPartManager { get{} }
}

