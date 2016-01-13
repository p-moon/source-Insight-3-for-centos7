public interface ISupportInitializeNotification : ISupportInitialize
{

	// Properties
	public bool IsInitialized { get{} }

	// Events
	public event System.EventHandler Initialized;
}

