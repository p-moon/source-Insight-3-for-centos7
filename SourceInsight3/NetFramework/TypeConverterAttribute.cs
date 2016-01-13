public class TypeConverterAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TypeConverterAttribute() {}
	public TypeConverterAttribute(Type type) {}
	public TypeConverterAttribute(string typeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public TypeConverterAttribute Default;

	// Properties
	public string ConverterTypeName { get{} }
	public object TypeId { get{} }
}

