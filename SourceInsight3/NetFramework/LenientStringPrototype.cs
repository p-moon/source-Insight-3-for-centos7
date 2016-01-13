public class LenientStringPrototype : StringPrototype, System.Reflection.IReflect, System.Collections.IEnumerable, System.Runtime.InteropServices.Expando.IExpando
{

	// Methods
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
	public object constructor;
	public object anchor;
	public object big;
	public object blink;
	public object bold;
	public object charAt;
	public object charCodeAt;
	public object concat;
	public object fixed;
	public object fontcolor;
	public object fontsize;
	public object indexOf;
	public object italics;
	public object lastIndexOf;
	public object link;
	public object localeCompare;
	public object match;
	public object replace;
	public object search;
	public object slice;
	public object small;
	public object split;
	public object strike;
	public object sub;
	public object substr;
	public object substring;
	public object sup;
	public object toLocaleLowerCase;
	public object toLocaleUpperCase;
	public object toLowerCase;
	public object toString;
	public object toUpperCase;
	public object valueOf;
	public Microsoft.JScript.Vsa.VsaEngine engine;

	// Properties
	public int length { get{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public object Item { get{} set{} }
	public Type UnderlyingSystemType { get{} }
}

