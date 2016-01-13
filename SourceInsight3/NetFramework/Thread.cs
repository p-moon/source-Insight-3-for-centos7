public class Thread : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.Runtime.InteropServices._Thread
{

	// Constructors
	public Thread(ThreadStart start) {}
	public Thread(ThreadStart start, int maxStackSize) {}
	public Thread(ParameterizedThreadStart start) {}
	public Thread(ParameterizedThreadStart start, int maxStackSize) {}

	// Methods
	public virtual int GetHashCode() {}
	public static void BeginCriticalRegion() {}
	public static void EndCriticalRegion() {}
	public static void BeginThreadAffinity() {}
	public static void EndThreadAffinity() {}
	public static void MemoryBarrier() {}
	public static System.AppDomain GetDomain() {}
	public void Start() {}
	public void Start(object parameter) {}
	public void SetCompressedStack(CompressedStack stack) {}
	public CompressedStack GetCompressedStack() {}
	public void Abort(object stateInfo) {}
	public void Abort() {}
	public static void ResetAbort() {}
	public void Suspend() {}
	public void Resume() {}
	public void Interrupt() {}
	public void Join() {}
	public bool Join(int millisecondsTimeout) {}
	public bool Join(System.TimeSpan timeout) {}
	public static void Sleep(int millisecondsTimeout) {}
	public static void Sleep(System.TimeSpan timeout) {}
	public static void SpinWait(int iterations) {}
	public ApartmentState GetApartmentState() {}
	public bool TrySetApartmentState(ApartmentState state) {}
	public void SetApartmentState(ApartmentState state) {}
	public static System.LocalDataStoreSlot AllocateDataSlot() {}
	public static System.LocalDataStoreSlot AllocateNamedDataSlot(string name) {}
	public static System.LocalDataStoreSlot GetNamedDataSlot(string name) {}
	public static void FreeNamedDataSlot(string name) {}
	public static object GetData(System.LocalDataStoreSlot slot) {}
	public static void SetData(System.LocalDataStoreSlot slot, object data) {}
	public static int GetDomainID() {}
	public static byte VolatileRead(System.Byte& address) {}
	public static short VolatileRead(System.Int16& address) {}
	public static int VolatileRead(System.Int32& address) {}
	public static long VolatileRead(System.Int64& address) {}
	public static System.SByte VolatileRead(System.SByte& address) {}
	public static ushort VolatileRead(System.UInt16& address) {}
	public static uint VolatileRead(System.UInt32& address) {}
	public static System.IntPtr VolatileRead(System.IntPtr& address) {}
	public static System.UIntPtr VolatileRead(System.UIntPtr& address) {}
	public static ulong VolatileRead(System.UInt64& address) {}
	public static float VolatileRead(System.Single& address) {}
	public static double VolatileRead(System.Double& address) {}
	public static object VolatileRead(System.Object& address) {}
	public static void VolatileWrite(System.Byte& address, byte value) {}
	public static void VolatileWrite(System.Int16& address, short value) {}
	public static void VolatileWrite(System.Int32& address, int value) {}
	public static void VolatileWrite(System.Int64& address, long value) {}
	public static void VolatileWrite(System.SByte& address, System.SByte value) {}
	public static void VolatileWrite(System.UInt16& address, ushort value) {}
	public static void VolatileWrite(System.UInt32& address, uint value) {}
	public static void VolatileWrite(System.IntPtr& address, System.IntPtr value) {}
	public static void VolatileWrite(System.UIntPtr& address, System.UIntPtr value) {}
	public static void VolatileWrite(System.UInt64& address, ulong value) {}
	public static void VolatileWrite(System.Single& address, float value) {}
	public static void VolatileWrite(System.Double& address, double value) {}
	public static void VolatileWrite(System.Object& address, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}

	// Properties
	public int ManagedThreadId { get{} }
	public ExecutionContext ExecutionContext { get{} }
	public ThreadPriority Priority { get{} set{} }
	public bool IsAlive { get{} }
	public bool IsThreadPoolThread { get{} }
	public Thread CurrentThread { get{} }
	public bool IsBackground { get{} set{} }
	public ThreadState ThreadState { get{} }
	public ApartmentState ApartmentState { get{} set{} }
	public System.Globalization.CultureInfo CurrentUICulture { get{} set{} }
	public System.Globalization.CultureInfo CurrentCulture { get{} set{} }
	public System.Runtime.Remoting.Contexts.Context CurrentContext { get{} }
	public System.Security.Principal.IPrincipal CurrentPrincipal { get{} set{} }
	public string Name { get{} set{} }
}

