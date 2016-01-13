public class MathObject : JSObject, System.Reflection.IReflect, System.Collections.IEnumerable, System.Runtime.InteropServices.Expando.IExpando
{

	// Methods
	public static double abs(double d) {}
	public static double acos(double x) {}
	public static double asin(double x) {}
	public static double atan(double x) {}
	public static double atan2(double dy, double dx) {}
	public static double ceil(double x) {}
	public static double cos(double x) {}
	public static double exp(double x) {}
	public static double floor(double x) {}
	public static double log(double x) {}
	public static double max(object x, object y, object[] args) {}
	public static double min(object x, object y, object[] args) {}
	public static double pow(double dx, double dy) {}
	public static double random() {}
	public static double round(double d) {}
	public static double sin(double x) {}
	public static double sqrt(double x) {}
	public static double tan(double x) {}
	public virtual System.Reflection.FieldInfo AddField(string name) {}
	public virtual System.Reflection.MemberInfo[] GetMember(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags bindingAttr) {}
	public void SetMemberValue2(string name, object value) {}
	public virtual string ToString() {}
	public virtual System.Reflection.FieldInfo GetField(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.MethodInfo GetMethod(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags bindingAttr) {}
	public ScriptObject GetParent() {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr) {}
	public virtual System.Reflection.PropertyInfo GetProperty(string name, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, Type returnType, Type[] types, System.Reflection.ParameterModifier[] modifiers) {}
	public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags bindingAttr) {}
	public virtual object InvokeMember(string name, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object target, object[] args, System.Reflection.ParameterModifier[] modifiers, System.Globalization.CultureInfo locale, string[] namedParameters) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public double E;
	public double LN10;
	public double LN2;
	public double LOG2E;
	public double LOG10E;
	public double PI;
	public double SQRT1_2;
	public double SQRT2;
	public Microsoft.JScript.Vsa.VsaEngine engine;

	// Properties
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public Type UnderlyingSystemType { get{} }
}

