public class SimplePropertyEntry : PropertyEntry
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PersistedValue { get{} set{} }
	public bool UseSetAttribute { get{} set{} }
	public object Value { get{} set{} }
	public string Filter { get{} set{} }
	public System.Reflection.PropertyInfo PropertyInfo { get{} set{} }
	public string Name { get{} set{} }
	public Type Type { get{} set{} }
	public Type DeclaringType { get{} }
}

