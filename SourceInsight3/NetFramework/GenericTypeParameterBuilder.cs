public class GenericTypeParameterBuilder : Type, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._Type, System.Reflection.IReflect
{

	// Methods
	public virtual string ToString() {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual Type MakePointerType() {}
	public virtual Type MakeByRefType() {}
	public virtual Type MakeArrayType() {}
	public virtual Type MakeArrayType(int rank) {}
	public virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) {}
	public virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) {}
	public virtual Type GetInterface(string name, bool ignoreCase) {}
	public virtual Type[] GetInterfaces() {}
	public virtual System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.EventInfo[] GetEvents() {}
	public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) {}
	public virtual Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) {}
	public virtual Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.InterfaceMapping GetInterfaceMap(Type interfaceType) {}
	public virtual System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) {}
	public virtual Type GetElementType() {}
	public virtual Type[] GetGenericArguments() {}
	public virtual Type GetGenericTypeDefinition() {}
	public virtual Type MakeGenericType(Type[] typeArguments) {}
	public virtual bool IsAssignableFrom(Type c) {}
	public virtual bool IsSubclassOf(Type c) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public void SetBaseTypeConstraint(Type baseTypeConstraint) {}
	public void SetInterfaceConstraints(Type[] interfaceConstraints) {}
	public void SetGenericParameterAttributes(System.Reflection.GenericParameterAttributes genericParameterAttributes) {}
	public virtual Type GetType() {}
	public virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Globalization.CultureInfo culture) {}
	public virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args) {}
	public virtual int GetArrayRank() {}
	public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.ConstructorInfo GetConstructor(Type[] types) {}
	public virtual System.Reflection.ConstructorInfo[] GetConstructors() {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, Type[] types) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name) {}
	public virtual System.Reflection.MethodInfo[] GetMethods() {}
	public virtual System.Reflection.FieldInfo GetField(string name) {}
	public virtual System.Reflection.FieldInfo[] GetFields() {}
	public virtual Type GetInterface(string name) {}
	public virtual Type[] FindInterfaces(System.Reflection.TypeFilter filter, object filterCriteria) {}
	public virtual System.Reflection.EventInfo GetEvent(string name) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, Type returnType, Type[] types) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, Type[] types) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, Type returnType) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name) {}
	public virtual System.Reflection.PropertyInfo[] GetProperties() {}
	public virtual Type[] GetNestedTypes() {}
	public virtual Type GetNestedType(string name) {}
	public virtual System.Reflection.MemberInfo[] GetMember(string name) {}
	public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MemberInfo[] GetMembers() {}
	public virtual System.Reflection.MemberInfo[] GetDefaultMembers() {}
	public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes memberType, System.Reflection.BindingFlags bindingAttr, System.Reflection.MemberFilter filter, object filterCriteria) {}
	public virtual Type[] GetGenericParameterConstraints() {}
	public virtual bool IsInstanceOfType(object o) {}
	public virtual bool Equals(Type o) {}
	public Type GetType() {}

	// Properties
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public string Name { get{} }
	public System.Reflection.Module Module { get{} }
	public System.Guid GUID { get{} }
	public System.Reflection.Assembly Assembly { get{} }
	public System.RuntimeTypeHandle TypeHandle { get{} }
	public string FullName { get{} }
	public string Namespace { get{} }
	public string AssemblyQualifiedName { get{} }
	public Type BaseType { get{} }
	public Type UnderlyingSystemType { get{} }
	public bool IsGenericTypeDefinition { get{} }
	public bool IsGenericType { get{} }
	public bool IsGenericParameter { get{} }
	public int GenericParameterPosition { get{} }
	public bool ContainsGenericParameters { get{} }
	public System.Reflection.MethodBase DeclaringMethod { get{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute { get{} }
	public System.Reflection.ConstructorInfo TypeInitializer { get{} }
	public bool IsNested { get{} }
	public System.Reflection.TypeAttributes Attributes { get{} }
	public System.Reflection.GenericParameterAttributes GenericParameterAttributes { get{} }
	public bool IsVisible { get{} }
	public bool IsNotPublic { get{} }
	public bool IsPublic { get{} }
	public bool IsNestedPublic { get{} }
	public bool IsNestedPrivate { get{} }
	public bool IsNestedFamily { get{} }
	public bool IsNestedAssembly { get{} }
	public bool IsNestedFamANDAssem { get{} }
	public bool IsNestedFamORAssem { get{} }
	public bool IsAutoLayout { get{} }
	public bool IsLayoutSequential { get{} }
	public bool IsExplicitLayout { get{} }
	public bool IsClass { get{} }
	public bool IsInterface { get{} }
	public bool IsValueType { get{} }
	public bool IsAbstract { get{} }
	public bool IsSealed { get{} }
	public bool IsEnum { get{} }
	public bool IsSpecialName { get{} }
	public bool IsImport { get{} }
	public bool IsSerializable { get{} }
	public bool IsAnsiClass { get{} }
	public bool IsUnicodeClass { get{} }
	public bool IsAutoClass { get{} }
	public bool IsArray { get{} }
	public bool IsByRef { get{} }
	public bool IsPointer { get{} }
	public bool IsPrimitive { get{} }
	public bool IsCOMObject { get{} }
	public bool HasElementType { get{} }
	public bool IsContextful { get{} }
	public bool IsMarshalByRef { get{} }
	public int MetadataToken { get{} }
}

