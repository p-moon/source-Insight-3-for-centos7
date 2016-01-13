public class WebPartConnectionsEventArgs : System.EventArgs
{

	// Constructors
	public WebPartConnectionsEventArgs(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint) {}
	public WebPartConnectionsEventArgs(WebPart provider, ProviderConnectionPoint providerConnectionPoint, WebPart consumer, ConsumerConnectionPoint consumerConnectionPoint, WebPartConnection connection) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartConnection Connection { get{} }
	public WebPart Consumer { get{} }
	public ConsumerConnectionPoint ConsumerConnectionPoint { get{} }
	public WebPart Provider { get{} }
	public ProviderConnectionPoint ProviderConnectionPoint { get{} }
}

