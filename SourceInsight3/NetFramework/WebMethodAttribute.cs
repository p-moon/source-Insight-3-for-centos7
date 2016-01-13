public class WebMethodAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebMethodAttribute() {}
	public WebMethodAttribute(bool enableSession) {}
	public WebMethodAttribute(bool enableSession, System.EnterpriseServices.TransactionOption transactionOption) {}
	public WebMethodAttribute(bool enableSession, System.EnterpriseServices.TransactionOption transactionOption, int cacheDuration) {}
	public WebMethodAttribute(bool enableSession, System.EnterpriseServices.TransactionOption transactionOption, int cacheDuration, bool bufferResponse) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Description { get{} set{} }
	public bool EnableSession { get{} set{} }
	public int CacheDuration { get{} set{} }
	public bool BufferResponse { get{} set{} }
	public System.EnterpriseServices.TransactionOption TransactionOption { get{} set{} }
	public string MessageName { get{} set{} }
	public object TypeId { get{} }
}

