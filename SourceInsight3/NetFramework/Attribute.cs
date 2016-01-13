public class Attribute : System.Runtime.InteropServices._Attribute
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public static Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, Type type) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, Type type, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.MemberInfo element, bool inherit) {}
	public static bool IsDefined(System.Reflection.MemberInfo element, Type attributeType) {}
	public static bool IsDefined(System.Reflection.MemberInfo element, Type attributeType, bool inherit) {}
	public static Attribute GetCustomAttribute(System.Reflection.MemberInfo element, Type attributeType) {}
	public static Attribute GetCustomAttribute(System.Reflection.MemberInfo element, Type attributeType, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, Type attributeType) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, Type attributeType, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.ParameterInfo element, bool inherit) {}
	public static bool IsDefined(System.Reflection.ParameterInfo element, Type attributeType) {}
	public static bool IsDefined(System.Reflection.ParameterInfo element, Type attributeType, bool inherit) {}
	public static Attribute GetCustomAttribute(System.Reflection.ParameterInfo element, Type attributeType) {}
	public static Attribute GetCustomAttribute(System.Reflection.ParameterInfo element, Type attributeType, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Module element, Type attributeType) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Module element) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Module element, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Module element, Type attributeType, bool inherit) {}
	public static bool IsDefined(System.Reflection.Module element, Type attributeType) {}
	public static bool IsDefined(System.Reflection.Module element, Type attributeType, bool inherit) {}
	public static Attribute GetCustomAttribute(System.Reflection.Module element, Type attributeType) {}
	public static Attribute GetCustomAttribute(System.Reflection.Module element, Type attributeType, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Assembly element, Type attributeType) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Assembly element, Type attributeType, bool inherit) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Assembly element) {}
	public static Attribute[] GetCustomAttributes(System.Reflection.Assembly element, bool inherit) {}
	public static bool IsDefined(System.Reflection.Assembly element, Type attributeType) {}
	public static bool IsDefined(System.Reflection.Assembly element, Type attributeType, bool inherit) {}
	public static Attribute GetCustomAttribute(System.Reflection.Assembly element, Type attributeType) {}
	public static Attribute GetCustomAttribute(System.Reflection.Assembly element, Type attributeType, bool inherit) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object TypeId { get{} }
}

