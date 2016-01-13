public class ForestTrustRelationshipCollision
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ForestTrustCollisionType CollisionType { get{} }
	public TopLevelNameCollisionOptions TopLevelNameCollisionOption { get{} }
	public DomainCollisionOptions DomainCollisionOption { get{} }
	public string CollisionRecord { get{} }
}

