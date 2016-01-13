public class DynamicMethod : System.Reflection.MethodInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._MethodBase, System.Runtime.InteropServices._MethodInfo
{

	// Constructors
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes) {}
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, bool restrictedSkipVisibility) {}
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, System.Reflection.Module m) {}
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) {}
	public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes, System.Reflection.Module m, bool skipVisibility) {}
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner) {}
	public DynamicMethod(string name, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) {}
	public DynamicMethod(string name, System.Reflection.MethodAttributes attributes, System.Reflection.CallingConventions callingConvention, Type returnType, Type[] parameterTypes, Type owner, bool skipVisibility) {}

	// Methods
	public System.Delegate CreateDelegate(Type delegateType) {}
	public System.Delegate CreateDelegate(Type delegateType, object target) {}
	public virtual string ToString() {}
	public virtual System.Reflection.MethodInfo GetBaseDefinition() {}
	public virtual System.Reflection.ParameterInfo[] GetParameters() {}
	public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags() {}
	public virtual object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string parameterName) {}
	public DynamicILInfo GetDynamicILInfo() {}
	public ILGenerator GetILGenerator() {}
	public ILGenerator GetILGenerator(int streamSize) {}
	public virtual Type[] GetGenericArguments() {}
	public virtual System.Reflection.MethodInfo GetGenericMethodDefinition() {}
	public virtual System.Reflection.MethodInfo MakeGenericMethod(Type[] typeArguments) {}
	public virtual object Invoke(object obj, object[] parameters) {}
	public virtual System.Reflection.MethodBody GetMethodBody() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public Type ReflectedType { get{} }
	public System.Reflection.Module Module { get{} }
	public System.RuntimeMethodHandle MethodHandle { get{} }
	public System.Reflection.MethodAttributes Attributes { get{} }
	public System.Reflection.CallingConventions CallingConvention { get{} }
	public Type ReturnType { get{} }
	public System.Reflection.ParameterInfo ReturnParameter { get{} }
	public System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get{} }
	public bool InitLocals { get{} set{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public bool IsGenericMethodDefinition { get{} }
	public bool ContainsGenericParameters { get{} }
	public bool IsGenericMethod { get{} }
	public bool IsPublic { get{} }
	public bool IsPrivate { get{} }
	public bool IsFamily { get{} }
	public bool IsAssembly { get{} }
	public bool IsFamilyAndAssembly { get{} }
	public bool IsFamilyOrAssembly { get{} }
	public bool IsStatic { get{} }
	public bool IsFinal { get{} }
	public bool IsVirtual { get{} }
	public bool IsHideBySig { get{} }
	public bool IsAbstract { get{} }
	public bool IsSpecialName { get{} }
	public bool IsConstructor { get{} }
	public int MetadataToken { get{} }
}

