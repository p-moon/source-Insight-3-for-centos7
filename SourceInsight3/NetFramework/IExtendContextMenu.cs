public interface IExtendContextMenu
{

	// Methods
	public abstract virtual void AddMenuItems(IDataObject piDataObject, IContextMenuCallback piCallback, System.Int32& pInsertionAllowed) {}
	public abstract virtual void Command(int lCommandID, IDataObject piDataObject) {}
}

