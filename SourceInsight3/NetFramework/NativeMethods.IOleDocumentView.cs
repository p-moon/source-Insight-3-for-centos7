public interface IOleDocumentView
{

	// Methods
	public abstract virtual void SetInPlaceSite(IOleInPlaceSite pIPSite) {}
	public abstract virtual IOleInPlaceSite GetInPlaceSite() {}
	public abstract virtual object GetDocument() {}
	public abstract virtual void SetRect(COMRECT prcView) {}
	public abstract virtual void GetRect(out COMRECT prcView) {}
	public abstract virtual void SetRectComplex(COMRECT prcView, COMRECT prcHScroll, COMRECT prcVScroll, COMRECT prcSizeBox) {}
	public abstract virtual void Show(int fShow) {}
	public abstract virtual void UIActivate(int fUIActivate) {}
	public abstract virtual void Open() {}
	public abstract virtual void CloseView(int dwReserved) {}
	public abstract virtual void SaveViewState(IStream pstm) {}
	public abstract virtual void ApplyViewState(IStream pstm) {}
	public abstract virtual void Clone(IOleInPlaceSite pIPSiteNewout , IOleDocumentView[] ppViewNew) {}
}

