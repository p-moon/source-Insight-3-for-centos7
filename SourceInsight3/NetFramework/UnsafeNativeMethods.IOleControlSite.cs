public interface IOleControlSite
{

	// Methods
	public abstract virtual int OnControlInfoChanged() {}
	public abstract virtual int LockInPlaceActive(int fLock) {}
	public abstract virtual int GetExtendedControl(out System.Object& ppDisp) {}
	public abstract virtual int TransformCoords(out _POINTL pPtlHimetricout , tagPOINTF pPtfContainer, int dwFlags) {}
	public abstract virtual int TranslateAccelerator(MSG& pMsg, int grfModifiers) {}
	public abstract virtual int OnFocus(int fGotFocus) {}
	public abstract virtual int ShowPropertyFrame() {}
}

