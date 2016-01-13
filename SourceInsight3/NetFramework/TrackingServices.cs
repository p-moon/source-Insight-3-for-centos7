public class TrackingServices
{

	// Constructors
	public TrackingServices() {}

	// Methods
	public static void RegisterTrackingHandler(ITrackingHandler handler) {}
	public static void UnregisterTrackingHandler(ITrackingHandler handler) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ITrackingHandler[] RegisteredHandlers { get{} }
}

