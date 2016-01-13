public interface ICustomMarshaler
{

	// Methods
	public abstract virtual object MarshalNativeToManaged(System.IntPtr pNativeData) {}
	public abstract virtual System.IntPtr MarshalManagedToNative(object ManagedObj) {}
	public abstract virtual void CleanUpNativeData(System.IntPtr pNativeData) {}
	public abstract virtual void CleanUpManagedData(object ManagedObj) {}
	public abstract virtual int GetNativeDataSize() {}
}

