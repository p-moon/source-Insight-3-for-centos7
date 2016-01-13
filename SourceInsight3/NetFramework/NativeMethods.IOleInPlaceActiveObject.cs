public interface IOleInPlaceActiveObject
{

	// Methods
	public abstract virtual int GetWindow(out System.IntPtr& hwnd) {}
	public abstract virtual void ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual int TranslateAccelerator(MSG& lpmsg) {}
	public abstract virtual void OnFrameWindowActivate(int fActivate) {}
	public abstract virtual void OnDocWindowActivate(int fActivate) {}
	public abstract virtual void ResizeBorder(COMRECT prcBorder, IOleInPlaceUIWindow pUIWindow, int fFrameWindow) {}
	public abstract virtual void EnableModeless(int fEnable) {}
}

