public interface _FieldInfo
{

	// Methods
	public abstract virtual void GetTypeInfoCount(out System.UInt32& pcTInfo) {}
	public abstract virtual void GetTypeInfo(uint iTInfo, uint lcid, System.IntPtr ppTInfo) {}
	public abstract virtual void GetIDsOfNames(System.Guid& riid, System.IntPtr rgszNames, uint cNames, uint lcid, System.IntPtr rgDispId) {}
	public abstract virtual void Invoke(uint dispIdMember, System.Guid& riid, uint lcid, short wFlags, System.IntPtr pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, System.IntPtr puArgErr) {}
	public abstract virtual string ToString() {}
	public abstract virtual bool Equals(object other) {}
	public abstract virtual int GetHashCode() {}
	public abstract virtual Type GetType() {}
	public abstract virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public abstract virtual object[] GetCustomAttributes(bool inherit) {}
	public abstract virtual bool IsDefined(Type attributeType, bool inherit) {}
	public abstract virtual object GetValue(object obj) {}
	public abstract virtual object GetValueDirect(System.TypedReference obj) {}
	public abstract virtual void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) {}
	public abstract virtual void SetValueDirect(System.TypedReference obj, object value) {}
	public abstract virtual void SetValue(object obj, object value) {}

	// Properties
	public System.Reflection.MemberTypes MemberType { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public Type FieldType { get{} }
	public System.RuntimeFieldHandle FieldHandle { get{} }
	public System.Reflection.FieldAttributes Attributes { get{} }
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
}

