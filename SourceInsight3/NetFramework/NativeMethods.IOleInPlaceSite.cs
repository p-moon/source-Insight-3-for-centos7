public interface IOleInPlaceSite
{

	// Methods
	public abstract virtual System.IntPtr GetWindow() {}
	public abstract virtual void ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual int CanInPlaceActivate() {}
	public abstract virtual void OnInPlaceActivate() {}
	public abstract virtual void OnUIActivate() {}
	public abstract virtual void GetWindowContext(out IOleInPlaceFrame& ppFrameout , IOleInPlaceUIWindow& ppDocout , COMRECT lprcPosRectout , COMRECT lprcClipRectout , tagOIFI lpFrameInfo) {}
	public abstract virtual int Scroll(tagSIZE scrollExtant) {}
	public abstract virtual void OnUIDeactivate(int fUndoable) {}
	public abstract virtual void OnInPlaceDeactivate() {}
	public abstract virtual void DiscardUndoState() {}
	public abstract virtual void DeactivateAndUndo() {}
	public abstract virtual int OnPosRectChange(COMRECT lprcPosRect) {}
}

