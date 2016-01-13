public interface _PropertyInfo
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
	public abstract virtual object GetValue(object obj, object[] index) {}
	public abstract virtual object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public abstract virtual void SetValue(object obj, object value, object[] index) {}
	public abstract virtual void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public abstract virtual System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) {}
	public abstract virtual System.Reflection.MethodInfo GetGetMethod(bool nonPublic) {}
	public abstract virtual System.Reflection.MethodInfo GetSetMethod(bool nonPublic) {}
	public abstract virtual System.Reflection.ParameterInfo[] GetIndexParameters() {}
	public abstract virtual System.Reflection.MethodInfo[] GetAccessors() {}
	public abstract virtual System.Reflection.MethodInfo GetGetMethod() {}
	public abstract virtual System.Reflection.MethodInfo GetSetMethod() {}

	// Properties
	public System.Reflection.MemberTypes MemberType { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public Type PropertyType { get{} }
	public System.Reflection.PropertyAttributes Attributes { get{} }
	public bool CanRead { get{} }
	public bool CanWrite { get{} }
	public bool IsSpecialName { get{} }
}

