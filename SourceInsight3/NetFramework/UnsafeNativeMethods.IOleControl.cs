public interface IOleControl
{

	// Methods
	public abstract virtual int GetControlInfo(out tagCONTROLINFO pCI) {}
	public abstract virtual int OnMnemonic(MSG& pMsg) {}
	public abstract virtual int OnAmbientPropertyChange(int dispID) {}
	public abstract virtual int FreezeEvents(int bFreeze) {}
}

