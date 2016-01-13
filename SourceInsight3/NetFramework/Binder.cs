public class Binder
{

	// Methods
	public abstract virtual MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, System.Object[]& args, ParameterModifier[] modifiers, System.Globalization.CultureInfo culture, string[] namesout , System.Object& state) {}
	public abstract virtual FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, System.Globalization.CultureInfo culture) {}
	public abstract virtual MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) {}
	public abstract virtual PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) {}
	public abstract virtual object ChangeType(object value, Type type, System.Globalization.CultureInfo culture) {}
	public abstract virtual void ReorderArgumentArray(System.Object[]& args, object state) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

