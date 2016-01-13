public interface IOleObject
{

	// Methods
	public abstract virtual int SetClientSite(IOleClientSite pClientSite) {}
	public abstract virtual int GetClientSite(out IOleClientSite& site) {}
	public abstract virtual int SetHostNames(string szContainerApp, string szContainerObj) {}
	public abstract virtual int Close(int dwSaveOption) {}
	public abstract virtual int SetMoniker(int dwWhichMoniker, object pmk) {}
	public abstract virtual int GetMoniker(int dwAssign, int dwWhichMonikerout , System.Object& moniker) {}
	public abstract virtual int InitFromData(System.Runtime.InteropServices.ComTypes.IDataObject pDataObject, int fCreation, int dwReserved) {}
	public abstract virtual int GetClipboardData(int dwReservedout , System.Runtime.InteropServices.ComTypes.IDataObject& data) {}
	public abstract virtual int DoVerb(int iVerb, System.IntPtr lpmsg, IOleClientSite pActiveSite, int lindex, System.IntPtr hwndParent, COMRECT lprcPosRect) {}
	public abstract virtual int EnumVerbs(out IEnumOLEVERB& e) {}
	public abstract virtual int OleUpdate() {}
	public abstract virtual int IsUpToDate() {}
	public abstract virtual int GetUserClassID(out System.Guid& pClsid) {}
	public abstract virtual int GetUserType(int dwFormOfTypeout , System.String& userType) {}
	public abstract virtual int SetExtent(int dwDrawAspect, tagSIZEL pSizel) {}
	public abstract virtual int GetExtent(int dwDrawAspectout , tagSIZEL pSizel) {}
	public abstract virtual int Advise(IAdviseSink pAdvSinkout , System.Int32& cookie) {}
	public abstract virtual int Unadvise(int dwConnection) {}
	public abstract virtual int EnumAdvise(out System.Object& e) {}
	public abstract virtual int GetMiscStatus(int dwAspectout , System.Int32& misc) {}
	public abstract virtual int SetColorScheme(tagLOGPALETTE pLogpal) {}
}

