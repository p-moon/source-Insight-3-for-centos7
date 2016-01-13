public class ForestTrustRelationshipInformation : TrustRelationshipInformation
{

	// Methods
	public void Save() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TopLevelNameCollection TopLevelNames { get{} }
	public System.Collections.Specialized.StringCollection ExcludedTopLevelNames { get{} }
	public ForestTrustDomainInfoCollection TrustedDomainInformation { get{} }
	public string SourceName { get{} }
	public string TargetName { get{} }
	public TrustType TrustType { get{} }
	public TrustDirection TrustDirection { get{} }
}

