public class StringPrototype : StringObject, System.Reflection.IReflect, System.Collections.IEnumerable, System.Runtime.InteropServices.Expando.IExpando
{

	// Methods
	public static string anchor(object thisob, object anchorName) {}
	public static string big(object thisob) {}
	public static string blink(object thisob) {}
	public static string bold(object thisob) {}
	public static string charAt(object thisob, double pos) {}
	public static object charCodeAt(object thisob, double pos) {}
	public static string concat(object thisob, object[] args) {}
	public static string fixed(object thisob) {}
	public static string fontcolor(object thisob, object colorName) {}
	public static string fontsize(object thisob, object fontSize) {}
	public static int indexOf(object thisob, object searchString, double position) {}
	public static string italics(object thisob) {}
	public static int lastIndexOf(object thisob, object searchString, double position) {}
	public static string link(object thisob, object linkRef) {}
	public static int localeCompare(object thisob, object thatob) {}
	public static object match(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, object regExp) {}
	public static string replace(object thisob, object regExp, object replacement) {}
	public static int search(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, object regExp) {}
	public static string slice(object thisob, double start, object end) {}
	public static string small(object thisob) {}
	public static ArrayObject split(object thisob, Microsoft.JScript.Vsa.VsaEngine engine, object separator, object limit) {}
	public static string strike(object thisob) {}
	public static string sub(object thisob) {}
	public static string substr(object thisob, double start, object count) {}
	public static string substring(object thisob, double start, object end) {}
	public static string sup(object thisob) {}
	public static string toLocaleLowerCase(object thisob) {}
	public static string toLocaleUpperCase(object thisob) {}
	public static string toLowerCase(object thisob) {}
	public static string toString(object thisob) {}
	public static string toUpperCase(object thisob) {}
	public static object valueOf(object thisob) {}
	public virtual bool Equals(object ob) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
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

	// Fields
	public Microsoft.JScript.Vsa.VsaEngine engine;

	// Properties
	public StringConstructor constructor { get{} }
	public int length { get{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public Type UnderlyingSystemType { get{} }
}

