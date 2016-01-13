public interface IExtendPropertySheet
{

	// Methods
	public abstract virtual int CreatePropertyPages(IPropertySheetCallback lpProvider, System.IntPtr handle, IDataObject lpIDataObject) {}
	public abstract virtual int QueryPagesFor(IDataObject lpDataObject) {}
}

