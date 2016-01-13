public class TrustManagerContext
{

	// Constructors
	public TrustManagerContext() {}
	public TrustManagerContext(TrustManagerUIContext uiContext) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TrustManagerUIContext UIContext { get{} set{} }
	public bool NoPrompt { get{} set{} }
	public bool IgnorePersistedDecision { get{} set{} }
	public bool KeepAlive { get{} set{} }
	public bool Persist { get{} set{} }
	public System.ApplicationIdentity PreviousApplicationIdentity { get{} set{} }
}

