public class LenientDatePrototype : DatePrototype, System.Reflection.IReflect, System.Collections.IEnumerable, System.Runtime.InteropServices.Expando.IExpando
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
	public object constructor;
	public object getTime;
	public object getYear;
	public object getFullYear;
	public object getUTCFullYear;
	public object getMonth;
	public object getUTCMonth;
	public object getDate;
	public object getUTCDate;
	public object getDay;
	public object getUTCDay;
	public object getHours;
	public object getUTCHours;
	public object getMinutes;
	public object getUTCMinutes;
	public object getSeconds;
	public object getUTCSeconds;
	public object getMilliseconds;
	public object getUTCMilliseconds;
	public object getVarDate;
	public object getTimezoneOffset;
	public object setTime;
	public object setMilliseconds;
	public object setUTCMilliseconds;
	public object setSeconds;
	public object setUTCSeconds;
	public object setMinutes;
	public object setUTCMinutes;
	public object setHours;
	public object setUTCHours;
	public object setDate;
	public object setUTCDate;
	public object setMonth;
	public object setUTCMonth;
	public object setFullYear;
	public object setUTCFullYear;
	public object setYear;
	public object toGMTString;
	public object toDateString;
	public object toLocaleDateString;
	public object toLocaleString;
	public object toLocaleTimeString;
	public object toString;
	public object toTimeString;
	public object toUTCString;
	public object valueOf;
	public Microsoft.JScript.Vsa.VsaEngine engine;

	// Properties
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public Type UnderlyingSystemType { get{} }
}

