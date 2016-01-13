public class XmlQualifiedName
{

	// Constructors
	public XmlQualifiedName() {}
	public XmlQualifiedName(string name) {}
	public XmlQualifiedName(string name, string ns) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual bool Equals(object other) {}
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) {}
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) {}
	public static string ToString(string name, string ns) {}
	public Type GetType() {}

	// Fields
	public XmlQualifiedName Empty;

	// Properties
	public string Namespace { get{} }
	public string Name { get{} }
	public bool IsEmpty { get{} }
}

