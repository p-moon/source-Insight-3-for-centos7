public class DesignerSerializationManager : IDesignerSerializationManager, System.IServiceProvider
{

	// Constructors
	public DesignerSerializationManager() {}
	public DesignerSerializationManager(System.IServiceProvider provider) {}

	// Methods
	public System.IDisposable CreateSession() {}
	public object GetSerializer(Type objectType, Type serializerType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.IContainer Container { get{} set{} }
	public System.Collections.IList Errors { get{} }
	public bool PreserveNames { get{} set{} }
	public object PropertyProvider { get{} set{} }
	public bool RecycleInstances { get{} set{} }
	public bool ValidateRecycledTypes { get{} set{} }

	// Events
	public event System.EventHandler SessionCreated;
	public event System.EventHandler SessionDisposed;
}

