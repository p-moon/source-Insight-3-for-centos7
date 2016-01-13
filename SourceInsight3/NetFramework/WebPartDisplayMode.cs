public class WebPartDisplayMode
{

	// Methods
	public virtual bool IsEnabled(WebPartManager webPartManager) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowPageDesign { get{} }
	public bool AssociatedWithToolZone { get{} }
	public string Name { get{} }
	public bool RequiresPersonalization { get{} }
	public bool ShowHiddenWebParts { get{} }
}

