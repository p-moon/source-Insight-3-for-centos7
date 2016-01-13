public class DatePrototype : DateObject, System.Reflection.IReflect, System.Collections.IEnumerable, System.Runtime.InteropServices.Expando.IExpando
{

	// Methods
	public static double getDate(object thisob) {}
	public static double getDay(object thisob) {}
	public static double getFullYear(object thisob) {}
	public static double getHours(object thisob) {}
	public static double getMilliseconds(object thisob) {}
	public static double getMinutes(object thisob) {}
	public static double getMonth(object thisob) {}
	public static double getSeconds(object thisob) {}
	public static double getTime(object thisob) {}
	public static double getTimezoneOffset(object thisob) {}
	public static double getUTCDate(object thisob) {}
	public static double getUTCDay(object thisob) {}
	public static double getUTCFullYear(object thisob) {}
	public static double getUTCHours(object thisob) {}
	public static double getUTCMilliseconds(object thisob) {}
	public static double getUTCMinutes(object thisob) {}
	public static double getUTCMonth(object thisob) {}
	public static double getUTCSeconds(object thisob) {}
	public static object getVarDate(object thisob) {}
	public static double getYear(object thisob) {}
	public static double setDate(object thisob, double ddate) {}
	public static double setFullYear(object thisob, double dyear, object month, object date) {}
	public static double setHours(object thisob, double dhour, object min, object sec, object msec) {}
	public static double setMinutes(object thisob, double dmin, object sec, object msec) {}
	public static double setMilliseconds(object thisob, double dmsec) {}
	public static double setMonth(object thisob, double dmonth, object date) {}
	public static double setSeconds(object thisob, double dsec, object msec) {}
	public static double setTime(object thisob, double time) {}
	public static double setUTCDate(object thisob, double ddate) {}
	public static double setUTCFullYear(object thisob, double dyear, object month, object date) {}
	public static double setUTCHours(object thisob, double dhour, object min, object sec, object msec) {}
	public static double setUTCMinutes(object thisob, double dmin, object sec, object msec) {}
	public static double setUTCMilliseconds(object thisob, double dmsec) {}
	public static double setUTCMonth(object thisob, double dmonth, object date) {}
	public static double setUTCSeconds(object thisob, double dsec, object msec) {}
	public static double setYear(object thisob, double dyear) {}
	public static string toDateString(object thisob) {}
	public static string toGMTString(object thisob) {}
	public static string toLocaleDateString(object thisob) {}
	public static string toLocaleString(object thisob) {}
	public static string toLocaleTimeString(object thisob) {}
	public static string toString(object thisob) {}
	public static string toTimeString(object thisob) {}
	public static string toUTCString(object thisob) {}
	public static double valueOf(object thisob) {}
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
	public Microsoft.JScript.Vsa.VsaEngine engine;

	// Properties
	public DateConstructor constructor { get{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public Type UnderlyingSystemType { get{} }
}

