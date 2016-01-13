public class PropertyConverter
{

	// Methods
	public static object EnumFromString(Type enumType, string value) {}
	public static string EnumToString(Type enumType, object enumValue) {}
	public static object ObjectFromString(Type objType, System.Reflection.MemberInfo propertyInfo, string value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

