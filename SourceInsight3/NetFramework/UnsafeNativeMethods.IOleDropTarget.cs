public interface IOleDropTarget
{

	// Methods
	public abstract virtual int OleDragEnter(object pDataObj, int grfKeyState, long ptout , System.Int32& pdwEffect) {}
	public abstract virtual int OleDragOver(int grfKeyState, long ptout , System.Int32& pdwEffect) {}
	public abstract virtual int OleDragLeave() {}
	public abstract virtual int OleDrop(object pDataObj, int grfKeyState, long ptout , System.Int32& pdwEffect) {}
}

