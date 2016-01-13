public class TypeDelegator : Type, ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._Type, IReflect
{

	// Constructors
	public TypeDelegator(Type delegatingType) {}

	// Methods
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) {}
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) {}
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) {}
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) {}
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) {}
	public virtual Type GetInterface(string name, bool ignoreCase) {}
	public virtual Type[] GetInterfaces() {}
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) {}
	public virtual EventInfo[] GetEvents() {}
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) {}
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) {}
	public virtual Type[] GetNestedTypes(BindingFlags bindingAttr) {}
	public virtual Type GetNestedType(string name, BindingFlags bindingAttr) {}
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) {}
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) {}
	public virtual Type GetElementType() {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public virtual InterfaceMapping GetInterfaceMap(Type interfaceType) {}
	public virtual Type GetType() {}
	public virtual Type MakePointerType() {}
	public virtual Type MakeByRefType() {}
	public virtual Type MakeArrayType() {}
	public virtual Type MakeArrayType(int rank) {}
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, System.Globalization.CultureInfo culture) {}
	public virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args) {}
	public virtual int GetArrayRank() {}
	public virtual ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) {}
	public virtual ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) {}
	public virtual ConstructorInfo GetConstructor(Type[] types) {}
	public virtual ConstructorInfo[] GetConstructors() {}
	public virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) {}
	public virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) {}
	public virtual MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) {}
	public virtual MethodInfo GetMethod(string name, Type[] types) {}
	public virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr) {}
	public virtual MethodInfo GetMethod(string name) {}
	public virtual MethodInfo[] GetMethods() {}
	public virtual FieldInfo GetField(string name) {}
	public virtual FieldInfo[] GetFields() {}
	public virtual Type GetInterface(string name) {}
	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) {}
	public virtual EventInfo GetEvent(string name) {}
	public virtual PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) {}
	public virtual PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) {}
	public virtual PropertyInfo GetProperty(string name, BindingFlags bindingAttr) {}
	public virtual PropertyInfo GetProperty(string name, Type returnType, Type[] types) {}
	public virtual PropertyInfo GetProperty(string name, Type[] types) {}
	public virtual PropertyInfo GetProperty(string name, Type returnType) {}
	public virtual PropertyInfo GetProperty(string name) {}
	public virtual PropertyInfo[] GetProperties() {}
	public virtual Type[] GetNestedTypes() {}
	public virtual Type GetNestedType(string name) {}
	public virtual MemberInfo[] GetMember(string name) {}
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) {}
	public virtual MemberInfo[] GetMembers() {}
	public virtual MemberInfo[] GetDefaultMembers() {}
	public virtual MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria) {}
	public virtual Type[] GetGenericParameterConstraints() {}
	public virtual Type MakeGenericType(Type[] typeArguments) {}
	public virtual Type[] GetGenericArguments() {}
	public virtual Type GetGenericTypeDefinition() {}
	public virtual bool IsSubclassOf(Type c) {}
	public virtual bool IsInstanceOfType(object o) {}
	public virtual bool IsAssignableFrom(Type c) {}
	public virtual string ToString() {}
	public virtual bool Equals(object o) {}
	public virtual bool Equals(Type o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public System.Guid GUID { get{} }
	public int MetadataToken { get{} }
	public Module Module { get{} }
	public Assembly Assembly { get{} }
	public System.RuntimeTypeHandle TypeHandle { get{} }
	public string Name { get{} }
	public string FullName { get{} }
	public string Namespace { get{} }
	public string AssemblyQualifiedName { get{} }
	public Type BaseType { get{} }
	public Type UnderlyingSystemType { get{} }
	public MemberTypes MemberType { get{} }
	public Type DeclaringType { get{} }
	public MethodBase DeclaringMethod { get{} }
	public Type ReflectedType { get{} }
	public System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute { get{} }
	public ConstructorInfo TypeInitializer { get{} }
	public bool IsNested { get{} }
	public TypeAttributes Attributes { get{} }
	public GenericParameterAttributes GenericParameterAttributes { get{} }
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
	public bool IsGenericType { get{} }
	public bool IsGenericTypeDefinition { get{} }
	public bool IsGenericParameter { get{} }
	public int GenericParameterPosition { get{} }
	public bool ContainsGenericParameters { get{} }
	public bool IsByRef { get{} }
	public bool IsPointer { get{} }
	public bool IsPrimitive { get{} }
	public bool IsCOMObject { get{} }
	public bool HasElementType { get{} }
	public bool IsContextful { get{} }
	public bool IsMarshalByRef { get{} }
}

