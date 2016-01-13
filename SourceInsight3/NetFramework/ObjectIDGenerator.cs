public class ObjectIDGenerator
{

	// Constructors
	public ObjectIDGenerator() {}

	// Methods
	public virtual long GetId(object objout , System.Boolean& firstTime) {}
	public virtual long HasId(object objout , System.Boolean& firstTime) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

