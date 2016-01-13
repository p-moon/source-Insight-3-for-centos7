public class Overlapped
{

	// Constructors
	public Overlapped() {}
	public Overlapped(int offsetLo, int offsetHi, System.IntPtr hEvent, System.IAsyncResult ar) {}
	public Overlapped(int offsetLo, int offsetHi, int hEvent, System.IAsyncResult ar) {}

	// Methods
	public NativeOverlapped* Pack(IOCompletionCallback iocb) {}
	public NativeOverlapped* Pack(IOCompletionCallback iocb, object userData) {}
	public NativeOverlapped* UnsafePack(IOCompletionCallback iocb) {}
	public NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData) {}
	public static Overlapped Unpack(NativeOverlapped* nativeOverlappedPtr) {}
	public static void Free(NativeOverlapped* nativeOverlappedPtr) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IAsyncResult AsyncResult { get{} set{} }
	public int OffsetLow { get{} set{} }
	public int OffsetHigh { get{} set{} }
	public int EventHandle { get{} set{} }
	public System.IntPtr EventHandleIntPtr { get{} set{} }
}

