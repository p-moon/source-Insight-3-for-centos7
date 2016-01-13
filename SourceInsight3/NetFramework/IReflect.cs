public interface IReflect
{

	// Methods
	public abstract virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) {}
	public abstract virtual MethodInfo GetMethod(string name, BindingFlags bindingAttr) {}
	public abstract virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) {}
	public abstract virtual FieldInfo GetField(string name, BindingFlags bindingAttr) {}
	public abstract virtual FieldInfo[] GetFields(BindingFlags bindingAttr) {}
	public abstract virtual PropertyInfo GetProperty(string name, BindingFlags bindingAttr) {}
	public abstract virtual PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) {}
	public abstract virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) {}
	public abstract virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) {}
	public abstract virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) {}
	public abstract virtual object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namedParameters) {}

	// Properties
	public Type UnderlyingSystemType { get{} }
}

