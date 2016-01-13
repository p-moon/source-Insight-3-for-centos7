public class RuntimeMethodHandle : ValueType, System.Runtime.Serialization.ISerializable
{

	// Methods
	public IntPtr GetFunctionPointer() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public static bool op_Equality(RuntimeMethodHandle left, RuntimeMethodHandle right) {}
	public static bool op_Inequality(RuntimeMethodHandle left, RuntimeMethodHandle right) {}
	public bool Equals(RuntimeMethodHandle handle) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public IntPtr Value { get{} }
}

