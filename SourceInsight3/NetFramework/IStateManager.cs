public interface IStateManager
{

	// Methods
	public abstract virtual void LoadViewState(object state) {}
	public abstract virtual object SaveViewState() {}
	public abstract virtual void TrackViewState() {}

	// Properties
	public bool IsTrackingViewState { get{} }
}

