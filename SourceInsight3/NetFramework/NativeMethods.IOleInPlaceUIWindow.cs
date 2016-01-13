public interface IOleInPlaceUIWindow
{

	// Methods
	public abstract virtual System.IntPtr GetWindow() {}
	public abstract virtual void ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual void GetBorder(out COMRECT lprectBorder) {}
	public abstract virtual void RequestBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual void SetBorderSpace(COMRECT pborderwidths) {}
	public abstract virtual void SetActiveObject(IOleInPlaceActiveObject pActiveObject, string pszObjName) {}
}

