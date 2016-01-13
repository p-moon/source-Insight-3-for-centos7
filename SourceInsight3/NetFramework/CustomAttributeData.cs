public class CustomAttributeData
{

	// Methods
	public static IList<System.Reflection.CustomAttributeData> GetCustomAttributes(MemberInfo target) {}
	public static IList<System.Reflection.CustomAttributeData> GetCustomAttributes(Module target) {}
	public static IList<System.Reflection.CustomAttributeData> GetCustomAttributes(Assembly target) {}
	public static IList<System.Reflection.CustomAttributeData> GetCustomAttributes(ParameterInfo target) {}
	public virtual string ToString() {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}

	// Properties
	public ConstructorInfo Constructor { get{} }
	public IList<System.Reflection.CustomAttributeTypedArgument> ConstructorArguments { get{} }
	public IList<System.Reflection.CustomAttributeNamedArgument> NamedArguments { get{} }
}

