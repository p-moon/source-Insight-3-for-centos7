public class RuntimeHelpers
{

	// Methods
	public static void InitializeArray(System.Array array, System.RuntimeFieldHandle fldHandle) {}
	public static void ProbeForSufficientStack() {}
	public static object GetObjectValue(object obj) {}
	public static void PrepareDelegate(System.Delegate d) {}
	public static void ExecuteCodeWithGuaranteedCleanup(TryCode code, CleanupCode backoutCode, object userData) {}
	public static void PrepareConstrainedRegions() {}
	public static void PrepareConstrainedRegionsNoOP() {}
	public static void RunClassConstructor(System.RuntimeTypeHandle type) {}
	public static void RunModuleConstructor(System.ModuleHandle module) {}
	public static void PrepareMethod(System.RuntimeMethodHandle method) {}
	public static void PrepareMethod(System.RuntimeMethodHandle method, System.RuntimeTypeHandle[] instantiation) {}
	public static int GetHashCode(object o) {}
	public static bool Equals(object o1, object o2) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int OffsetToStringData { get{} }
}

