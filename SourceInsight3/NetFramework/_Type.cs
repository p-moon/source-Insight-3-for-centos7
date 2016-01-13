public interface _Type
{

	// Methods
	public abstract virtual System.Reflection.MethodInfo GetMethod(string name) {}
	public abstract virtual System.Reflection.MethodInfo[] GetMethods() {}
	public abstract virtual System.Reflection.FieldInfo GetField(string name) {}
	public abstract virtual System.Reflection.FieldInfo[] GetFields() {}
	public abstract virtual Type GetInterface(string name) {}
	public abstract virtual System.Reflection.EventInfo GetEvent(string name) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name, Type returnType, Type[] types) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name, Type[] types) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name, Type returnType) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name) {}
	public abstract virtual System.Reflection.PropertyInfo[] GetProperties() {}
	public abstract virtual Type[] GetNestedTypes() {}
	public abstract virtual Type GetNestedType(string name) {}
	public abstract virtual System.Reflection.MemberInfo[] GetMember(string name) {}
	public abstract virtual System.Reflection.MemberInfo[] GetMembers() {}
	public abstract virtual bool Equals(Type o) {}
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
	public abstract virtual int GetArrayRank() {}
	public abstract virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual Type GetInterface(string name, bool ignoreCase) {}
	public abstract virtual Type[] GetInterfaces() {}
	public abstract virtual Type[] FindInterfaces(System.Reflection.TypeFilter filter, object filterCriteria) {}
	public abstract virtual System.Reflection.EventInfo GetEvent(string name, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.EventInfo[] GetEvents() {}
	public abstract virtual System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual Type[] GetNestedTypes(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual Type GetNestedType(string name, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.MemberTypes type, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.MemberInfo[] GetDefaultMembers() {}
	public abstract virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes memberType, System.Reflection.BindingFlags bindingAttr, System.Reflection.MemberFilter filter, object filterCriteria) {}
	public abstract virtual Type GetElementType() {}
	public abstract virtual bool IsSubclassOf(Type c) {}
	public abstract virtual bool IsInstanceOfType(object o) {}
	public abstract virtual bool IsAssignableFrom(Type c) {}
	public abstract virtual System.Reflection.InterfaceMapping GetInterfaceMap(Type interfaceType) {}
	public abstract virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) {}
	public abstract virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) {}
	public abstract virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Globalization.CultureInfo culture) {}
	public abstract virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args) {}
	public abstract virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.ConstructorInfo GetConstructor(Type[] types) {}
	public abstract virtual System.Reflection.ConstructorInfo[] GetConstructors() {}
	public abstract virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, System.Reflection.CallingConventions callConvention, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.MethodInfo GetMethod(string name, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public abstract virtual System.Reflection.MethodInfo GetMethod(string name, Type[] types) {}

	// Properties
	public System.Reflection.MemberTypes MemberType { get{} }
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public System.Guid GUID { get{} }
	public System.Reflection.Module Module { get{} }
	public System.Reflection.Assembly Assembly { get{} }
	public System.RuntimeTypeHandle TypeHandle { get{} }
	public string FullName { get{} }
	public string Namespace { get{} }
	public string AssemblyQualifiedName { get{} }
	public Type BaseType { get{} }
	public Type UnderlyingSystemType { get{} }
	public System.Reflection.ConstructorInfo TypeInitializer { get{} }
	public System.Reflection.TypeAttributes Attributes { get{} }
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
}

