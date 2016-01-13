public interface IOleDropTarget
{

	// Methods
	public abstract virtual int OleDragEnter(System.Runtime.InteropServices.ComTypes.IDataObject pDataObj, int grfKeyState, long ptout , System.Int32& pdwEffect) {}
	public abstract virtual int OleDragOver(int grfKeyState, long ptout , System.Int32& pdwEffect) {}
	public abstract virtual int OleDragLeave() {}
	public abstract virtual int OleDrop(System.Runtime.InteropServices.ComTypes.IDataObject pDataObj, int grfKeyState, long ptout , System.Int32& pdwEffect) {}
}

