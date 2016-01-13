public class NativeWindow : System.MarshalByRefObject, IWin32Window
{

	// Constructors
	public NativeWindow() {}

	// Methods
	public void AssignHandle(System.IntPtr handle) {}
	public virtual void CreateHandle(CreateParams cp) {}
	public void DefWndProc(Message& m) {}
	public virtual void DestroyHandle() {}
	public static NativeWindow FromHandle(System.IntPtr handle) {}
	public virtual void ReleaseHandle() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr Handle { get{} }
}

