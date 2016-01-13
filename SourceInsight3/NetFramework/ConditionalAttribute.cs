public class ConditionalAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ConditionalAttribute(string conditionString) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ConditionString { get{} }
	public object TypeId { get{} }
}

