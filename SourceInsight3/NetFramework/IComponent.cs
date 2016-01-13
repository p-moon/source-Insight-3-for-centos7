public interface IComponent : System.IDisposable
{

	// Properties
	public ISite Site { get{} set{} }

	// Events
	public event System.EventHandler Disposed;
}

