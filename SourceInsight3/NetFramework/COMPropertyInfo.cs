public class COMPropertyInfo : System.Reflection.PropertyInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._PropertyInfo, MemberInfoInitializer
{

	// Constructors
	public COMPropertyInfo() {}

	// Methods
	public virtual System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) {}
	public virtual object[] GetCustomAttributes(Type t, bool inherit) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual System.Reflection.MethodInfo GetGetMethod(bool nonPublic) {}
	public virtual System.Reflection.ParameterInfo[] GetIndexParameters() {}
	public virtual System.Reflection.MethodInfo GetSetMethod(bool nonPublic) {}
	public virtual object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public virtual void Initialize(string name, COMMemberInfo dispatch) {}
	public virtual COMMemberInfo GetCOMMemberInfo() {}
	public virtual void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public virtual bool IsDefined(Type t, bool inherit) {}
	public virtual object GetConstantValue() {}
	public virtual object GetRawConstantValue() {}
	public virtual object GetValue(object obj, object[] index) {}
	public virtual void SetValue(object obj, object value, object[] index) {}
	public virtual Type[] GetRequiredCustomModifiers() {}
	public virtual Type[] GetOptionalCustomModifiers() {}
	public virtual System.Reflection.MethodInfo[] GetAccessors() {}
	public virtual System.Reflection.MethodInfo GetGetMethod() {}
	public virtual System.Reflection.MethodInfo GetSetMethod() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Reflection.PropertyAttributes Attributes { get{} }
	public bool CanRead { get{} }
	public bool CanWrite { get{} }
	public Type DeclaringType { get{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public string Name { get{} }
	public Type ReflectedType { get{} }
	public Type PropertyType { get{} }
	public bool IsSpecialName { get{} }
	public int MetadataToken { get{} }
	public System.Reflection.Module Module { get{} }
}

