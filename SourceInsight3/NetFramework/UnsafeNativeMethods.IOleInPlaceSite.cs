public interface IOleInPlaceSite
{

	// Methods
	public abstract virtual System.IntPtr GetWindow() {}
	public abstract virtual int ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual int CanInPlaceActivate() {}
	public abstract virtual int OnInPlaceActivate() {}
	public abstract virtual int OnUIActivate() {}
	public abstract virtual int GetWindowContext(out IOleInPlaceFrame& ppFrameout , IOleInPlaceUIWindow& ppDocout , COMRECT lprcPosRectout , COMRECT lprcClipRectout , tagOIFI lpFrameInfo) {}
	public abstract virtual int Scroll(tagSIZE scrollExtant) {}
	public abstract virtual int OnUIDeactivate(int fUndoable) {}
	public abstract virtual int OnInPlaceDeactivate() {}
	public abstract virtual int DiscardUndoState() {}
	public abstract virtual int DeactivateAndUndo() {}
	public abstract virtual int OnPosRectChange(COMRECT lprcPosRect) {}
}

