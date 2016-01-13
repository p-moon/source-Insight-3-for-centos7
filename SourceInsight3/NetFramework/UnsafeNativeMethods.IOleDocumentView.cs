public interface IOleDocumentView
{

	// Methods
	public abstract virtual void SetInPlaceSite(IOleInPlaceSite pIPSite) {}
	public abstract virtual IOleInPlaceSite GetInPlaceSite() {}
	public abstract virtual object GetDocument() {}
	public abstract virtual void SetRect(RECT& prcView) {}
	public abstract virtual void GetRect(out RECT& prcView) {}
	public abstract virtual void SetRectComplex(RECT prcView, RECT prcHScroll, RECT prcVScroll, RECT prcSizeBox) {}
	public abstract virtual void Show(bool fShow) {}
	public abstract virtual int UIActivate(bool fUIActivate) {}
	public abstract virtual void Open() {}
	public abstract virtual int Close(int dwReserved) {}
	public abstract virtual void SaveViewState(IStream pstm) {}
	public abstract virtual void ApplyViewState(IStream pstm) {}
	public abstract virtual void Clone(IOleInPlaceSite pIPSiteNewout , IOleDocumentView[] ppViewNew) {}
}

