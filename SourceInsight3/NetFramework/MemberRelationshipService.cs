public class MemberRelationshipService
{

	// Methods
	public abstract virtual bool SupportsRelationship(MemberRelationship source, MemberRelationship relationship) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MemberRelationship Item { get{} set{} }
	public MemberRelationship Item { get{} set{} }
}

