public class PersonalizationStateQuery
{

	// Constructors
	public PersonalizationStateQuery() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PathToMatch { get{} set{} }
	public System.DateTime UserInactiveSinceDate { get{} set{} }
	public string UsernameToMatch { get{} set{} }
	public object Item { get{} set{} }
}

