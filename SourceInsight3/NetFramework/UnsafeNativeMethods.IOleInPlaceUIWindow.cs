public interface IOleInPlaceUIWindow
{

	// Methods
	public abstract virtual System.IntPtr GetWindow() {}
	public abstract virtual int ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual int GetBorder(out COMRECT lprectBorder) {}
	public abstract virtual int RequestBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual int SetBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual void SetActiveObject(IOleInPlaceActiveObject pActiveObject, string pszObjName) {}
}

