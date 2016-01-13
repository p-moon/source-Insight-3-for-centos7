public class FieldBuilder : System.Reflection.FieldInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._FieldInfo, System.Runtime.InteropServices._FieldBuilder
{

	// Methods
	public virtual object GetValue(object obj) {}
	public virtual void SetValue(object obj, object val, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public FieldToken GetToken() {}
	public void SetOffset(int iOffset) {}
	public void SetMarshal(UnmanagedMarshal unmanagedMarshal) {}
	public void SetConstant(object defaultValue) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public virtual Type[] GetRequiredCustomModifiers() {}
	public virtual Type[] GetOptionalCustomModifiers() {}
	public virtual void SetValueDirect(System.TypedReference obj, object value) {}
	public virtual object GetValueDirect(System.TypedReference obj) {}
	public virtual object GetRawConstantValue() {}
	public virtual void SetValue(object obj, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Reflection.Module Module { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public Type FieldType { get{} }
	public System.RuntimeFieldHandle FieldHandle { get{} }
	public System.Reflection.FieldAttributes Attributes { get{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public bool IsPublic { get{} }
	public bool IsPrivate { get{} }
	public bool IsFamily { get{} }
	public bool IsAssembly { get{} }
	public bool IsFamilyAndAssembly { get{} }
	public bool IsFamilyOrAssembly { get{} }
	public bool IsStatic { get{} }
	public bool IsInitOnly { get{} }
	public bool IsLiteral { get{} }
	public bool IsNotSerialized { get{} }
	public bool IsSpecialName { get{} }
	public bool IsPinvokeImpl { get{} }
	public int MetadataToken { get{} }
}

