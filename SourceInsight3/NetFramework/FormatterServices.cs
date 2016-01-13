public class FormatterServices
{

	// Methods
	public static System.Reflection.MemberInfo[] GetSerializableMembers(Type type) {}
	public static System.Reflection.MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) {}
	public static void CheckTypeSecurity(Type t, System.Runtime.Serialization.Formatters.TypeFilterLevel securityLevel) {}
	public static object GetUninitializedObject(Type type) {}
	public static object GetSafeUninitializedObject(Type type) {}
	public static object PopulateObjectMembers(object obj, System.Reflection.MemberInfo[] members, object[] data) {}
	public static object[] GetObjectData(object obj, System.Reflection.MemberInfo[] members) {}
	public static ISerializationSurrogate GetSurrogateForCyclicalReference(ISerializationSurrogate innerSurrogate) {}
	public static Type GetTypeFromAssembly(System.Reflection.Assembly assem, string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

