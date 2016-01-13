public class JSMethod : System.Reflection.MethodInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._MethodBase, System.Runtime.InteropServices._MethodInfo
{

	// Methods
	public virtual System.Reflection.MethodInfo GetBaseDefinition() {}
	public virtual object[] GetCustomAttributes(Type t, bool inherit) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags() {}
	public virtual object Invoke(object obj, System.Reflection.BindingFlags options, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) {}
	public virtual bool IsDefined(Type type, bool inherit) {}
	public virtual Type[] GetGenericArguments() {}
	public virtual System.Reflection.MethodInfo GetGenericMethodDefinition() {}
	public virtual System.Reflection.MethodInfo MakeGenericMethod(Type[] typeArguments) {}
	public abstract virtual System.Reflection.ParameterInfo[] GetParameters() {}
	public virtual object Invoke(object obj, object[] parameters) {}
	public virtual System.Reflection.MethodBody GetMethodBody() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Reflection.MemberTypes MemberType { get{} }
	public System.RuntimeMethodHandle MethodHandle { get{} }
	public Type ReflectedType { get{} }
	public System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes { get{} }
	public Type ReturnType { get{} }
	public System.Reflection.ParameterInfo ReturnParameter { get{} }
	public bool IsGenericMethodDefinition { get{} }
	public bool ContainsGenericParameters { get{} }
	public bool IsGenericMethod { get{} }
	public System.Reflection.MethodAttributes Attributes { get{} }
	public System.Reflection.CallingConventions CallingConvention { get{} }
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
	public string Name { get{} }
	public Type DeclaringType { get{} }
	public int MetadataToken { get{} }
	public System.Reflection.Module Module { get{} }
}

