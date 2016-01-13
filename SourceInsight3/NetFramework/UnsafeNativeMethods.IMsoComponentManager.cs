public interface IMsoComponentManager
{

	// Methods
	public abstract virtual int QueryService(System.Guid& guidService, System.Guid& iidout , System.Object& ppvObj) {}
	public abstract virtual bool FDebugMessage(System.IntPtr hInst, int msg, System.IntPtr wParam, System.IntPtr lParam) {}
	public abstract virtual bool FRegisterComponent(IMsoComponent component, MSOCRINFOSTRUCT pcrinfoout , System.Int32& dwComponentID) {}
	public abstract virtual bool FRevokeComponent(int dwComponentID) {}
	public abstract virtual bool FUpdateComponentRegistration(int dwComponentID, MSOCRINFOSTRUCT pcrinfo) {}
	public abstract virtual bool FOnComponentActivate(int dwComponentID) {}
	public abstract virtual bool FSetTrackingComponent(int dwComponentID, bool fTrack) {}
	public abstract virtual void OnComponentEnterState(int dwComponentID, int uStateID, int uContext, int cpicmExclude, int rgpicmExclude, int dwReserved) {}
	public abstract virtual bool FOnComponentExitState(int dwComponentID, int uStateID, int uContext, int cpicmExclude, int rgpicmExclude) {}
	public abstract virtual bool FInState(int uStateID, System.IntPtr pvoid) {}
	public abstract virtual bool FContinueIdle() {}
	public abstract virtual bool FPushMessageLoop(int dwComponentID, int uReason, int pvLoopData) {}
	public abstract virtual bool FCreateSubComponentManager(object punkOuter, object punkServProv, System.Guid& riidout , System.IntPtr& ppvObj) {}
	public abstract virtual bool FGetParentComponentManager(out IMsoComponentManager& ppicm) {}
	public abstract virtual bool FGetActiveComponent(int dwgacout , IMsoComponent[] ppic, MSOCRINFOSTRUCT pcrinfo, int dwReserved) {}
}

