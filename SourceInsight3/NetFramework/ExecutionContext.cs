public class ExecutionContext : System.Runtime.Serialization.ISerializable
{

	// Methods
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) {}
	public ExecutionContext CreateCopy() {}
	public static AsyncFlowControl SuppressFlow() {}
	public static void RestoreFlow() {}
	public static bool IsFlowSuppressed() {}
	public static ExecutionContext Capture() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

