public class EnumerableToDispatchMarshaler : System.Runtime.InteropServices.ICustomMarshaler
{

	// Methods
	public virtual object MarshalNativeToManaged(System.IntPtr pNativeData) {}
	public virtual System.IntPtr MarshalManagedToNative(object pManagedObj) {}
	public virtual void CleanUpNativeData(System.IntPtr pNativeData) {}
	public virtual void CleanUpManagedData(object pManagedObj) {}
	public virtual int GetNativeDataSize() {}
	public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

