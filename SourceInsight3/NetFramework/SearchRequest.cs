public class SearchRequest : DirectoryRequest
{

	// Constructors
	public SearchRequest() {}
	public SearchRequest(string distinguishedName, System.Xml.XmlDocument filter, SearchScope searchScope, string[] attributeList) {}
	public SearchRequest(string distinguishedName, string ldapFilter, SearchScope searchScope, string[] attributeList) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DistinguishedName { get{} set{} }
	public System.Collections.Specialized.StringCollection Attributes { get{} }
	public object Filter { get{} set{} }
	public SearchScope Scope { get{} set{} }
	public DereferenceAlias Aliases { get{} set{} }
	public int SizeLimit { get{} set{} }
	public System.TimeSpan TimeLimit { get{} set{} }
	public bool TypesOnly { get{} set{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

