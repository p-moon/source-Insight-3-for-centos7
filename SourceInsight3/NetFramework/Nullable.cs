public class Nullable
{

	// Methods
	public static int Compare<T>(Nullable<T> n1, Nullable<T> n2) {}
	public static bool Equals<T>(Nullable<T> n1, Nullable<T> n2) {}
	public static Type GetUnderlyingType(Type nullableType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

