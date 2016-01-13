public class SubjectIdentifier
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SubjectIdentifierType Type { get{} }
	public object Value { get{} }
}

