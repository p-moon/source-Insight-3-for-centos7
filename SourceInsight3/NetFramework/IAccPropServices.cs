public interface IAccPropServices
{

	// Methods
	public abstract virtual void SetPropValue(System.Byte& pIDString, uint dwIDStringLen, System.Guid idProp, object var) {}
	public abstract virtual void SetPropServer(System.Byte& pIDString, uint dwIDStringLen, System.Guid& paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope) {}
	public abstract virtual void ClearProps(System.Byte& pIDString, uint dwIDStringLen, System.Guid& paProps, int cProps) {}
	public abstract virtual void SetHwndProp(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid idProp, object var) {}
	public abstract virtual void SetHwndPropStr(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid idProp, string str) {}
	public abstract virtual void SetHwndPropServer(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid& paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope) {}
	public abstract virtual void ClearHwndProps(_RemotableHandle& hwnd, uint idObject, uint idChild, System.Guid& paProps, int cProps) {}
	public abstract virtual void ComposeHwndIdentityString(_RemotableHandle& hwnd, uint idObject, uint idChildout , System.IntPtr ppIDStringout , System.UInt32& pdwIDStringLen) {}
	public abstract virtual void DecomposeHwndIdentityString(System.Byte& pIDString, uint dwIDStringLenout , System.IntPtr phwndout , System.UInt32& pidObjectout , System.UInt32& pidChild) {}
	public abstract virtual void SetHmenuProp(_RemotableHandle& hmenu, uint idChild, System.Guid idProp, object var) {}
	public abstract virtual void SetHmenuPropStr(_RemotableHandle& hmenu, uint idChild, System.Guid idProp, string str) {}
	public abstract virtual void SetHmenuPropServer(_RemotableHandle& hmenu, uint idChild, System.Guid& paProps, int cProps, IAccPropServer pServer, AnnoScope AnnoScope) {}
	public abstract virtual void ClearHmenuProps(_RemotableHandle& hmenu, uint idChild, System.Guid& paProps, int cProps) {}
	public abstract virtual void ComposeHmenuIdentityString(_RemotableHandle& hmenu, uint idChildout , System.IntPtr ppIDStringout , System.UInt32& pdwIDStringLen) {}
	public abstract virtual void DecomposeHmenuIdentityString(System.Byte& pIDString, uint dwIDStringLenout , System.IntPtr phmenuout , System.UInt32& pidChild) {}
}

