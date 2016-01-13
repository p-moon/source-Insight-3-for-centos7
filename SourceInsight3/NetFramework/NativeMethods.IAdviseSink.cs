public interface IAdviseSink
{

	// Methods
	public abstract virtual void OnDataChange(FORMATETC pFormatetc, STGMEDIUM pStgmed) {}
	public abstract virtual void OnViewChange(int dwAspect, int lindex) {}
	public abstract virtual void OnRename(object pmk) {}
	public abstract virtual void OnSave() {}
	public abstract virtual void OnClose() {}
}

