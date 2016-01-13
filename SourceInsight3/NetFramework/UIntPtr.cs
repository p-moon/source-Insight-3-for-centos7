public class UIntPtr : ValueType, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public UIntPtr(uint value) {}
	public UIntPtr(ulong value) {}
	public UIntPtr(void* value) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public uint ToUInt32() {}
	public ulong ToUInt64() {}
	public virtual string ToString() {}
	public static UIntPtr op_Explicit(uint value) {}
	public static UIntPtr op_Explicit(ulong value) {}
	public static uint op_Explicit(UIntPtr value) {}
	public static ulong op_Explicit(UIntPtr value) {}
	public static UIntPtr op_Explicit(void* value) {}
	public static void* op_Explicit(UIntPtr value) {}
	public static bool op_Equality(UIntPtr value1, UIntPtr value2) {}
	public static bool op_Inequality(UIntPtr value1, UIntPtr value2) {}
	public void* ToPointer() {}
	public Type GetType() {}

	// Fields
	public UIntPtr Zero;

	// Properties
	public int Size { get{} }
}

