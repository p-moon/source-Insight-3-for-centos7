public class ModifyDNResponse : DirectoryResponse
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string RequestId { get{} }
	public string MatchedDN { get{} }
	public DirectoryControl[] Controls { get{} }
	public ResultCode ResultCode { get{} }
	public string ErrorMessage { get{} }
	public System.Uri[] Referral { get{} }
}

