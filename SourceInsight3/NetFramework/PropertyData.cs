public class PropertyData
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public object Value { get{} set{} }
	public CimType Type { get{} }
	public bool IsLocal { get{} }
	public bool IsArray { get{} }
	public string Origin { get{} }
	public QualifierDataCollection Qualifiers { get{} }
}

