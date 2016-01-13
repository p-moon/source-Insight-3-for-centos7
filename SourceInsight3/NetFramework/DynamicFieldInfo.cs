public class DynamicFieldInfo
{

	// Constructors
	public DynamicFieldInfo(string name, object value) {}
	public DynamicFieldInfo(string name, object value, string fieldTypeName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string name;
	public object value;
	public string fieldTypeName;
}

