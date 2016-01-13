public class WebPartTracker : System.IDisposable
{

	// Constructors
	public WebPartTracker(WebPart webPart, ProviderConnectionPoint providerConnectionPoint) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsCircularConnection { get{} }
}

