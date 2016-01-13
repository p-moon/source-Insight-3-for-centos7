public interface IDocHostUIHandler
{

	// Methods
	public abstract virtual int ShowContextMenu(int dwID, POINT pt, object pcmdtReserved, object pdispReserved) {}
	public abstract virtual int GetHostInfo(out DOCHOSTUIINFO info) {}
	public abstract virtual int ShowUI(int dwID, IOleInPlaceActiveObject activeObject, IOleCommandTarget commandTarget, IOleInPlaceFrame frame, IOleInPlaceUIWindow doc) {}
	public abstract virtual int HideUI() {}
	public abstract virtual int UpdateUI() {}
	public abstract virtual int EnableModeless(bool fEnable) {}
	public abstract virtual int OnDocWindowActivate(bool fActivate) {}
	public abstract virtual int OnFrameWindowActivate(bool fActivate) {}
	public abstract virtual int ResizeBorder(COMRECT rect, IOleInPlaceUIWindow doc, bool fFrameWindow) {}
	public abstract virtual int TranslateAccelerator(MSG& msg, System.Guid& group, int nCmdID) {}
	public abstract virtual int GetOptionKeyPath(out string[] pbstrKey, int dw) {}
	public abstract virtual int GetDropTarget(IOleDropTarget pDropTargetout , IOleDropTarget& ppDropTarget) {}
	public abstract virtual int GetExternal(out System.Object& ppDispatch) {}
	public abstract virtual int TranslateUrl(int dwTranslate, string strURLInout , System.String& pstrURLOut) {}
	public abstract virtual int FilterDataObject(System.Runtime.InteropServices.ComTypes.IDataObject pDOout , System.Runtime.InteropServices.ComTypes.IDataObject& ppDORet) {}
}

