public class SoundPlayer : System.ComponentModel.Component, System.ComponentModel.IComponent, System.IDisposable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public SoundPlayer() {}
	public SoundPlayer(string soundLocation) {}
	public SoundPlayer(System.IO.Stream stream) {}

	// Methods
	public void LoadAsync() {}
	public void Load() {}
	public void Play() {}
	public void PlaySync() {}
	public void PlayLooping() {}
	public void Stop() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int LoadTimeout { get{} set{} }
	public string SoundLocation { get{} set{} }
	public System.IO.Stream Stream { get{} set{} }
	public bool IsLoadCompleted { get{} }
	public object Tag { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.ComponentModel.AsyncCompletedEventHandler LoadCompleted;
	public event System.EventHandler SoundLocationChanged;
	public event System.EventHandler StreamChanged;
	public event System.EventHandler Disposed;
}

