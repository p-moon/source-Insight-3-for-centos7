public class GCHandle : System.ValueType
{

	// Methods
	public static GCHandle Alloc(object value) {}
	public static GCHandle Alloc(object value, GCHandleType type) {}
	public void Free() {}
	public System.IntPtr AddrOfPinnedObject() {}
	public static GCHandle op_Explicit(System.IntPtr value) {}
	public static GCHandle FromIntPtr(System.IntPtr value) {}
	public static System.IntPtr op_Explicit(GCHandle value) {}
	public static System.IntPtr ToIntPtr(GCHandle value) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object o) {}
	public static bool op_Equality(GCHandle a, GCHandle b) {}
	public static bool op_Inequality(GCHandle a, GCHandle b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public object Target { get{} set{} }
	public bool IsAllocated { get{} }
}

