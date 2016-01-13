public interface IOleInPlaceFrame
{

	// Methods
	public abstract virtual System.IntPtr GetWindow() {}
	public abstract virtual int ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual int GetBorder(out COMRECT lprectBorder) {}
	public abstract virtual int RequestBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual int SetBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual int SetActiveObject(IOleInPlaceActiveObject pActiveObject, string pszObjName) {}
	public abstract virtual int InsertMenus(System.IntPtr hmenuSharedout , tagOleMenuGroupWidths lpMenuWidths) {}
	public abstract virtual int SetMenu(System.IntPtr hmenuShared, System.IntPtr holemenu, System.IntPtr hwndActiveObject) {}
	public abstract virtual int RemoveMenus(System.IntPtr hmenuShared) {}
	public abstract virtual int SetStatusText(string pszStatusText) {}
	public abstract virtual int EnableModeless(bool fEnable) {}
	public abstract virtual int TranslateAccelerator(MSG& lpmsg, short wID) {}
}

