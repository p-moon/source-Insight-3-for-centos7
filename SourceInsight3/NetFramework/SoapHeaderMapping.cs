public class SoapHeaderMapping
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type HeaderType { get{} }
	public bool Repeats { get{} }
	public bool Custom { get{} }
	public SoapHeaderDirection Direction { get{} }
	public System.Reflection.MemberInfo MemberInfo { get{} }
}

