public class MethodBuilder : System.Reflection.MethodInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._MethodBase, System.Runtime.InteropServices._MethodInfo, System.Runtime.InteropServices._MethodBuilder
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) {}
	public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags() {}
	public virtual System.Reflection.MethodInfo GetBaseDefinition() {}
	public virtual System.Reflection.ParameterInfo[] GetParameters() {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public virtual System.Reflection.MethodInfo GetGenericMethodDefinition() {}
	public virtual Type[] GetGenericArguments() {}
	public virtual System.Reflection.MethodInfo MakeGenericMethod(Type[] typeArguments) {}
	public GenericTypeParameterBuilder[] DefineGenericParameters(string[] names) {}
	public MethodToken GetToken() {}
	public void SetParameters(Type[] parameterTypes) {}
	public void SetReturnType(Type returnType) {}
	public void SetSignature(Type returnType, Type[] returnTypeRequiredCustomModifiers, Type[] returnTypeOptionalCustomModifiers, Type[] parameterTypes, Type[][] parameterTypeRequiredCustomModifiers, Type[][] parameterTypeOptionalCustomModifiers) {}
	public ParameterBuilder DefineParameter(int position, System.Reflection.ParameterAttributes attributes, string strParamName) {}
	public void SetMarshal(UnmanagedMarshal unmanagedMarshal) {}
	public void SetSymCustomAttribute(string name, byte[] data) {}
	public void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction action, System.Security.PermissionSet pset) {}
	public void CreateMethodBody(byte[] il, int count) {}
	public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) {}
	public ILGenerator GetILGenerator() {}
	public ILGenerator GetILGenerator(int size) {}
	public System.Reflection.Module GetModule() {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public virtual object Invoke(object obj, object[] parameters) {}
	public virtual System.Reflection.MethodBody GetMethodBody() {}
	public Type GetType() {}

	// Properties
	public string Name { get{} }
	public System.Reflection.Module Module { get{} }
	public Type DeclaringType { get{} }
	public System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get{} }
	public Type ReflectedType { get{} }
	public System.Reflection.MethodAttributes Attributes { get{} }
	public System.Reflection.CallingConventions CallingConvention { get{} }
	public System.RuntimeMethodHandle MethodHandle { get{} }
	public System.Reflection.ParameterInfo ReturnParameter { get{} }
	public bool IsGenericMethodDefinition { get{} }
	public bool ContainsGenericParameters { get{} }
	public bool IsGenericMethod { get{} }
	public bool InitLocals { get{} set{} }
	public string Signature { get{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public Type ReturnType { get{} }
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

