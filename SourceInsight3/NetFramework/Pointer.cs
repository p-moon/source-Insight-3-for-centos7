public class Pointer : System.Runtime.Serialization.ISerializable
{

	// Methods
	public static object Box(void* ptr, Type type) {}
	public static void* Unbox(object ptr) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

