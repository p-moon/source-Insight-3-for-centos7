public interface IExtendPropertySheet2
{

	// Methods
	public abstract virtual int CreatePropertyPages(IPropertySheetCallback lpProvider, System.IntPtr handle, IDataObject lpIDataObject) {}
	public abstract virtual int QueryPagesFor(IDataObject lpDataObject) {}
	public abstract virtual int GetWatermarks(IDataObject lpIDataObjectout , System.IntPtr& lphWatermarkout , System.IntPtr& lphHeaderout , System.IntPtr& lphPaletteout , System.Int32& bStretch) {}
}

