public class FieldInfo : MemberInfo, ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._FieldInfo
{

	// Methods
	public static FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle) {}
	public static FieldInfo GetFieldFromHandle(System.RuntimeFieldHandle handle, System.RuntimeTypeHandle declaringType) {}
	public virtual Type[] GetRequiredCustomModifiers() {}
	public virtual Type[] GetOptionalCustomModifiers() {}
	public virtual void SetValueDirect(System.TypedReference obj, object value) {}
	public virtual object GetValueDirect(System.TypedReference obj) {}
	public abstract virtual object GetValue(object obj) {}
	public virtual object GetRawConstantValue() {}
	public abstract virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, System.Globalization.CultureInfo culture) {}
	public virtual void SetValue(object obj, object value) {}
	public abstract virtual object[] GetCustomAttributes(bool inherit) {}
	public abstract virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public abstract virtual bool IsDefined(Type attributeType, bool inherit) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MemberTypes MemberType { get{} }
	public System.RuntimeFieldHandle FieldHandle { get{} }
	public Type FieldType { get{} }
	public FieldAttributes Attributes { get{} }
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
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public int MetadataToken { get{} }
	public Module Module { get{} }
}

