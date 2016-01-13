public class LenientMathObject : MathObject, System.Reflection.IReflect, System.Collections.IEnumerable, System.Runtime.InteropServices.Expando.IExpando
{

	// Methods
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
	public object abs;
	public object acos;
	public object asin;
	public object atan;
	public object atan2;
	public object ceil;
	public object cos;
	public object exp;
	public object floor;
	public object log;
	public object max;
	public object min;
	public object pow;
	public object random;
	public object round;
	public object sin;
	public object sqrt;
	public object tan;
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

