public class ComplexPropertyEntry : BuilderPropertyEntry
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsCollectionItem { get{} }
	public bool ReadOnly { get{} set{} }
	public ControlBuilder Builder { get{} set{} }
	public string Filter { get{} set{} }
	public System.Reflection.PropertyInfo PropertyInfo { get{} set{} }
	public string Name { get{} set{} }
	public Type Type { get{} set{} }
	public Type DeclaringType { get{} }
}

