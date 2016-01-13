public interface IOleClientSite
{

	// Methods
	public abstract virtual void SaveObject() {}
	public abstract virtual object GetMoniker(int dwAssign, int dwWhichMoniker) {}
	public abstract virtual int GetContainer(out IOleContainer& ppContainer) {}
	public abstract virtual void ShowObject() {}
	public abstract virtual void OnShowWindow(int fShow) {}
	public abstract virtual void RequestNewObjectLayout() {}
}

