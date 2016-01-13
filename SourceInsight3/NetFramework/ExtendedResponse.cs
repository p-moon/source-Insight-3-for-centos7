public class ExtendedResponse : DirectoryResponse
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ResponseName { get{} }
	public byte[] ResponseValue { get{} }
	public string RequestId { get{} }
	public string MatchedDN { get{} }
	public DirectoryControl[] Controls { get{} }
	public ResultCode ResultCode { get{} }
	public string ErrorMessage { get{} }
	public System.Uri[] Referral { get{} }
}

