public class RuntimeTypeHandle : ValueType, System.Runtime.Serialization.ISerializable
{

	// Methods
	public static bool op_Equality(RuntimeTypeHandle left, object right) {}
	public static bool op_Equality(object left, RuntimeTypeHandle right) {}
	public static bool op_Inequality(RuntimeTypeHandle left, object right) {}
	public static bool op_Inequality(object left, RuntimeTypeHandle right) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(RuntimeTypeHandle handle) {}
	public ModuleHandle GetModuleHandle() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public IntPtr Value { get{} }
}

