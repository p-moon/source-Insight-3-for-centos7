public interface IMobileWebFormServices
{

	// Methods
	public abstract virtual object GetCache(string controlID, object key) {}
	public abstract virtual void SetCache(string controlID, object key, object value) {}
	public abstract virtual void RefreshPageView() {}
	public abstract virtual void UpdateRenderingRecursive(System.Web.UI.Control rootControl) {}
	public abstract virtual void ClearUndoStack() {}
}

