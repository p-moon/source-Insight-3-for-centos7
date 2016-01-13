public class PropertyInfo : MemberInfo, ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._PropertyInfo
{

	// Methods
	public virtual object GetConstantValue() {}
	public virtual object GetRawConstantValue() {}
	public abstract virtual void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public abstract virtual MethodInfo[] GetAccessors(bool nonPublic) {}
	public abstract virtual MethodInfo GetGetMethod(bool nonPublic) {}
	public abstract virtual MethodInfo GetSetMethod(bool nonPublic) {}
	public abstract virtual ParameterInfo[] GetIndexParameters() {}
	public virtual object GetValue(object obj, object[] index) {}
	public abstract virtual object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public virtual void SetValue(object obj, object value, object[] index) {}
	public virtual Type[] GetRequiredCustomModifiers() {}
	public virtual Type[] GetOptionalCustomModifiers() {}
	public virtual MethodInfo[] GetAccessors() {}
	public virtual MethodInfo GetGetMethod() {}
	public virtual MethodInfo GetSetMethod() {}
	public abstract virtual object[] GetCustomAttributes(bool inherit) {}
	public abstract virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public abstract virtual bool IsDefined(Type attributeType, bool inherit) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MemberTypes MemberType { get{} }
	public Type PropertyType { get{} }
	public PropertyAttributes Attributes { get{} }
	public bool CanRead { get{} }
	public bool CanWrite { get{} }
	public bool IsSpecialName { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public int MetadataToken { get{} }
	public Module Module { get{} }
}

