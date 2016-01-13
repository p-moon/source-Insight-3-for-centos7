public interface IRichEditOleCallback
{

	// Methods
	public abstract virtual int GetNewStorage(out IStorage& ret) {}
	public abstract virtual int GetInPlaceContext(System.IntPtr lplpFrame, System.IntPtr lplpDoc, System.IntPtr lpFrameInfo) {}
	public abstract virtual int ShowContainerUI(int fShow) {}
	public abstract virtual int QueryInsertObject(System.Guid& lpclsid, System.IntPtr lpstg, int cp) {}
	public abstract virtual int DeleteObject(System.IntPtr lpoleobj) {}
	public abstract virtual int QueryAcceptData(System.Runtime.InteropServices.ComTypes.IDataObject lpdataobj, System.IntPtr lpcfFormat, int reco, int fReally, System.IntPtr hMetaPict) {}
	public abstract virtual int ContextSensitiveHelp(int fEnterMode) {}
	public abstract virtual int GetClipboardData(CHARRANGE lpchrg, int reco, System.IntPtr lplpdataobj) {}
	public abstract virtual int GetDragDropEffect(bool fDrag, int grfKeyState, System.Int32& pdwEffect) {}
	public abstract virtual int GetContextMenu(short seltype, System.IntPtr lpoleobj, CHARRANGE lpchrgout , System.IntPtr& hmenu) {}
}

