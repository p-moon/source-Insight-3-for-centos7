public class XmlReflectionMember
{

	// Constructors
	public XmlReflectionMember() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type MemberType { get{} set{} }
	public XmlAttributes XmlAttributes { get{} set{} }
	public SoapAttributes SoapAttributes { get{} set{} }
	public string MemberName { get{} set{} }
	public bool IsReturnValue { get{} set{} }
	public bool OverrideIsNullable { get{} set{} }
}

