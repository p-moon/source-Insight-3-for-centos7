public interface IOleInPlaceFrame
{

	// Methods
	public abstract virtual System.IntPtr GetWindow() {}
	public abstract virtual void ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual void GetBorder(out COMRECT lprectBorder) {}
	public abstract virtual void RequestBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual void SetBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual void SetActiveObject(IOleInPlaceActiveObject pActiveObject, string pszObjName) {}
	public abstract virtual void InsertMenus(System.IntPtr hmenuSharedout , object lpMenuWidths) {}
	public abstract virtual void SetMenu(System.IntPtr hmenuShared, System.IntPtr holemenu, System.IntPtr hwndActiveObject) {}
	public abstract virtual void RemoveMenus(System.IntPtr hmenuShared) {}
	public abstract virtual void SetStatusText(string pszStatusText) {}
	public abstract virtual void EnableModeless(int fEnable) {}
	public abstract virtual int TranslateAccelerator(MSG& lpmsg, short wID) {}
}

