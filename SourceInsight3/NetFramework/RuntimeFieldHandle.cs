public class RuntimeFieldHandle : ValueType, System.Runtime.Serialization.ISerializable
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(RuntimeFieldHandle handle) {}
	public static bool op_Equality(RuntimeFieldHandle left, RuntimeFieldHandle right) {}
	public static bool op_Inequality(RuntimeFieldHandle left, RuntimeFieldHandle right) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public IntPtr Value { get{} }
}

