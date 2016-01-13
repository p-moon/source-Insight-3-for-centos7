public interface IViewObject
{

	// Methods
	public abstract virtual int Draw(int dwDrawAspect, int lindex, System.IntPtr pvAspect, tagDVTARGETDEVICE ptd, System.IntPtr hdcTargetDev, System.IntPtr hdcDraw, COMRECT lprcBounds, COMRECT lprcWBounds, System.IntPtr pfnContinue, int dwContinue) {}
	public abstract virtual int GetColorSet(int dwDrawAspect, int lindex, System.IntPtr pvAspect, tagDVTARGETDEVICE ptd, System.IntPtr hicTargetDevout , tagLOGPALETTE ppColorSet) {}
	public abstract virtual int Freeze(int dwDrawAspect, int lindex, System.IntPtr pvAspectout , System.IntPtr pdwFreeze) {}
	public abstract virtual int Unfreeze(int dwFreeze) {}
	public abstract virtual void SetAdvise(int aspects, int advf, System.Runtime.InteropServices.ComTypes.IAdviseSink pAdvSink) {}
	public abstract virtual void GetAdvise(out int[] paspectsout , int[] advfout , System.Runtime.InteropServices.ComTypes.IAdviseSink[] pAdvSink) {}
}

