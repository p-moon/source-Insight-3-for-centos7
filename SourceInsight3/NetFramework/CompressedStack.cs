public class CompressedStack : System.Runtime.Serialization.ISerializable
{

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public static CompressedStack GetCompressedStack() {}
	public static CompressedStack Capture() {}
	public static void Run(CompressedStack compressedStack, ContextCallback callback, object state) {}
	public CompressedStack CreateCopy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

