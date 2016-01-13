public interface ITrackingHandler
{

	// Methods
	public abstract virtual void MarshaledObject(object obj, System.Runtime.Remoting.ObjRef or) {}
	public abstract virtual void UnmarshaledObject(object obj, System.Runtime.Remoting.ObjRef or) {}
	public abstract virtual void DisconnectedObject(object obj) {}
}

