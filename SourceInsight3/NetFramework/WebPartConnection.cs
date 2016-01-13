public class WebPartConnection
{

	// Constructors
	public WebPartConnection() {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPart Consumer { get{} }
	public ConsumerConnectionPoint ConsumerConnectionPoint { get{} }
	public string ConsumerConnectionPointID { get{} set{} }
	public string ConsumerID { get{} set{} }
	public string ID { get{} set{} }
	public bool IsActive { get{} }
	public bool IsShared { get{} }
	public bool IsStatic { get{} }
	public WebPart Provider { get{} }
	public ProviderConnectionPoint ProviderConnectionPoint { get{} }
	public string ProviderConnectionPointID { get{} set{} }
	public string ProviderID { get{} set{} }
	public WebPartTransformer Transformer { get{} }
	public WebPartTransformerCollection Transformers { get{} }
}

