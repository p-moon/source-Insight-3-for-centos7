public interface ITrackingPersonalizable
{

	// Methods
	public abstract virtual void BeginLoad() {}
	public abstract virtual void BeginSave() {}
	public abstract virtual void EndLoad() {}
	public abstract virtual void EndSave() {}

	// Properties
	public bool TracksChanges { get{} }
}

