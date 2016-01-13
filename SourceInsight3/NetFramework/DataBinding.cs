public class DataBinding
{

	// Constructors
	public DataBinding(string propertyName, Type propertyType, string expression) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Expression { get{} set{} }
	public string PropertyName { get{} }
	public Type PropertyType { get{} }
}

