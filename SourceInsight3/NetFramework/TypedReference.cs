public class TypedReference : ValueType
{

	// Methods
	public static TypedReference MakeTypedReference(object target, System.Reflection.FieldInfo[] flds) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public static object ToObject(TypedReference value) {}
	public static Type GetTargetType(TypedReference value) {}
	public static RuntimeTypeHandle TargetTypeToken(TypedReference value) {}
	public static void SetTypedReference(TypedReference target, object value) {}
	public virtual string ToString() {}
	public Type GetType() {}
}

