public class PropertyBuilder : System.Reflection.PropertyInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._PropertyInfo, System.Runtime.InteropServices._PropertyBuilder
{

	// Methods
	public void SetConstant(object defaultValue) {}
	public void SetGetMethod(MethodBuilder mdBuilder) {}
	public void SetSetMethod(MethodBuilder mdBuilder) {}
	public void AddOtherMethod(MethodBuilder mdBuilder) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public virtual object GetValue(object obj, object[] index) {}
	public virtual object GetValue(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public virtual void SetValue(object obj, object value, object[] index) {}
	public virtual void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] index, System.Globalization.CultureInfo culture) {}
	public virtual System.Reflection.MethodInfo[] GetAccessors(bool nonPublic) {}
	public virtual System.Reflection.MethodInfo GetGetMethod(bool nonPublic) {}
	public virtual System.Reflection.MethodInfo GetSetMethod(bool nonPublic) {}
	public virtual System.Reflection.ParameterInfo[] GetIndexParameters() {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public virtual object GetConstantValue() {}
	public virtual object GetRawConstantValue() {}
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
	public PropertyToken PropertyToken { get{} }
	public System.Reflection.Module Module { get{} }
	public Type PropertyType { get{} }
	public System.Reflection.PropertyAttributes Attributes { get{} }
	public bool CanRead { get{} }
	public bool CanWrite { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public bool IsSpecialName { get{} }
	public int MetadataToken { get{} }
}

