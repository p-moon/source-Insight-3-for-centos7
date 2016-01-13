public interface IOleDocument
{

	// Methods
	public abstract virtual int CreateView(IOleInPlaceSite pIPSite, IStream pstm, int dwReservedout , IOleDocumentView& ppView) {}
	public abstract virtual int GetDocMiscStatus(out System.Int32& pdwStatus) {}
	public abstract virtual int EnumViews(out System.Object& ppEnumout , IOleDocumentView& ppView) {}
}

