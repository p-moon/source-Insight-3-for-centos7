public class CAccPropServicesClass : System.__ComObject, IAccPropServices, CAccPropServices
{

	// Constructors
	public CAccPropServicesClass() {}

	// Methods
	public virtual void SetPropValue(System.Byte& pIDString, uint dwIDStringLen, System.Guid idProp, object var) {}
	public virtual void SetPropServer(System.Byte& pIDString, uint dwIDStringLen, System.Guid& paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope) {}
	public virtual void ClearProps(System.Byte& pIDString, uint dwIDStringLen, System.Guid& paProps, int cProps) {}
	public virtual void SetHwndProp(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid idProp, object var) {}
	public virtual void SetHwndPropStr(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid idProp, string str) {}
	public virtual void SetHwndPropServer(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid& paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope) {}
	public virtual void ClearHwndProps(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid& paProps, int cProps) {}
	public virtual void ComposeHwndIdentityString(_RemotableHandle& hwnd, uint idObject, uint idChildout , System.IntPtr ppIDStringout , System.UInt32& pdwIDStringLen) {}
	public virtual void DecomposeHwndIdentityString(System.Byte& pIDString, uint dwIDStringLenout , System.IntPtr phwndout , System.UInt32& pidObjectout , System.UInt32& pidChild) {}
	public virtual void SetHmenuProp(_RemotableHandle& hmenu, uint idChild, System.Guid idProp, object var) {}
	public virtual void SetHmenuPropStr(_RemotableHandle& hmenu, uint idChild, System.Guid idProp, string str) {}
	public virtual void SetHmenuPropServer(_RemotableHandle& hmenu, uint idChild, System.Guid& paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope) {}
	public virtual void ClearHmenuProps(_RemotableHandle& hmenu, uint idChild, System.Guid& paProps, int cProps) {}
	public virtual void ComposeHmenuIdentityString(_RemotableHandle& hmenu, uint idChildout , System.IntPtr ppIDStringout , System.UInt32& pdwIDStringLen) {}
	public virtual void DecomposeHmenuIdentityString(System.Byte& pIDString, uint dwIDStringLenout , System.IntPtr phmenuout , System.UInt32& pidChild) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

