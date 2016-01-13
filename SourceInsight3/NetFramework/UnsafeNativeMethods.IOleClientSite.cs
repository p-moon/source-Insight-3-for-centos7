public interface IOleClientSite
{

	// Methods
	public abstract virtual int SaveObject() {}
	public abstract virtual int GetMoniker(int dwAssign, int dwWhichMonikerout , System.Object& moniker) {}
	public abstract virtual int GetContainer(out IOleContainer& container) {}
	public abstract virtual int ShowObject() {}
	public abstract virtual int OnShowWindow(int fShow) {}
	public abstract virtual int RequestNewObjectLayout() {}
}

