public class SearchResponse : DirectoryResponse
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MatchedDN { get{} }
	public DirectoryControl[] Controls { get{} }
	public ResultCode ResultCode { get{} }
	public string ErrorMessage { get{} }
	public System.Uri[] Referral { get{} }
	public SearchResultReferenceCollection References { get{} }
	public SearchResultEntryCollection Entries { get{} }
	public string RequestId { get{} }
}

