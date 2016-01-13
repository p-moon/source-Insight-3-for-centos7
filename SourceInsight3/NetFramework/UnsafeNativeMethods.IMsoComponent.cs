public interface IMsoComponent
{

	// Methods
	public abstract virtual bool FDebugMessage(System.IntPtr hInst, int msg, System.IntPtr wParam, System.IntPtr lParam) {}
	public abstract virtual bool FPreTranslateMessage(MSG& msg) {}
	public abstract virtual void OnEnterState(int uStateID, bool fEnter) {}
	public abstract virtual void OnAppActivate(bool fActive, int dwOtherThreadID) {}
	public abstract virtual void OnLoseActivation() {}
	public abstract virtual void OnActivationChange(IMsoComponent component, bool fSameComponent, int pcrinfo, bool fHostIsActivating, int pchostinfo, int dwReserved) {}
	public abstract virtual bool FDoIdle(int grfidlef) {}
	public abstract virtual bool FContinueMessageLoop(int uReason, int pvLoopData, MSG[] pMsgPeeked) {}
	public abstract virtual bool FQueryTerminate(bool fPromptUser) {}
	public abstract virtual void Terminate() {}
	public abstract virtual System.IntPtr HwndGetWindow(int dwWhich, int dwReserved) {}
}

