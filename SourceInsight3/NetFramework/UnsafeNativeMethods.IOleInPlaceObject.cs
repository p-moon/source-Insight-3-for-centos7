public interface IOleInPlaceObject
{

	// Methods
	public abstract virtual int GetWindow(out System.IntPtr& hwnd) {}
	public abstract virtual void ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual void InPlaceDeactivate() {}
	public abstract virtual int UIDeactivate() {}
	public abstract virtual void SetObjectRects(COMRECT lprcPosRect, COMRECT lprcClipRect) {}
	public abstract virtual void ReactivateAndUndo() {}
}

