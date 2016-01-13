public class IntPtr : ValueType, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public IntPtr(int value) {}
	public IntPtr(long value) {}
	public IntPtr(void* value) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public static IntPtr op_Explicit(int value) {}
	public static bool op_Equality(IntPtr value1, IntPtr value2) {}
	public static bool op_Inequality(IntPtr value1, IntPtr value2) {}
	public int ToInt32() {}
	public long ToInt64() {}
	public string ToString(string format) {}
	public static IntPtr op_Explicit(long value) {}
	public static IntPtr op_Explicit(void* value) {}
	public static void* op_Explicit(IntPtr value) {}
	public static int op_Explicit(IntPtr value) {}
	public static long op_Explicit(IntPtr value) {}
	public void* ToPointer() {}
	public Type GetType() {}

	// Fields
	public IntPtr Zero;

	// Properties
	public int Size { get{} }
}

