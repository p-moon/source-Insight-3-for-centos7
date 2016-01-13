public class PersonalizationEntry
{

	// Constructors
	public PersonalizationEntry(object value, PersonalizationScope scope) {}
	public PersonalizationEntry(object value, PersonalizationScope scope, bool isSensitive) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PersonalizationScope Scope { get{} set{} }
	public object Value { get{} set{} }
	public bool IsSensitive { get{} set{} }
}

