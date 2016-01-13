public interface IAdviseSink
{

	// Methods
	public abstract virtual void OnDataChange(FORMATETC& format, STGMEDIUM& stgmedium) {}
	public abstract virtual void OnViewChange(int aspect, int index) {}
	public abstract virtual void OnRename(IMoniker moniker) {}
	public abstract virtual void OnSave() {}
	public abstract virtual void OnClose() {}
}

