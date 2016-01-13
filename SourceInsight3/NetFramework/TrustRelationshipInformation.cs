public class TrustRelationshipInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SourceName { get{} }
	public string TargetName { get{} }
	public TrustType TrustType { get{} }
	public TrustDirection TrustDirection { get{} }
}

