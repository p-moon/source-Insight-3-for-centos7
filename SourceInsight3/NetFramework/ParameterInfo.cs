public class ParameterInfo : System.Runtime.InteropServices._ParameterInfo, ICustomAttributeProvider
{

	// Methods
	public virtual Type[] GetRequiredCustomModifiers() {}
	public virtual Type[] GetOptionalCustomModifiers() {}
	public virtual string ToString() {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type ParameterType { get{} }
	public string Name { get{} }
	public object DefaultValue { get{} }
	public object RawDefaultValue { get{} }
	public int Position { get{} }
	public ParameterAttributes Attributes { get{} }
	public MemberInfo Member { get{} }
	public bool IsIn { get{} }
	public bool IsOut { get{} }
	public bool IsLcid { get{} }
	public bool IsRetval { get{} }
	public bool IsOptional { get{} }
	public int MetadataToken { get{} }
}

