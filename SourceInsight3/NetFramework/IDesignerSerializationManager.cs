public interface IDesignerSerializationManager : System.IServiceProvider
{

	// Methods
	public abstract virtual void AddSerializationProvider(IDesignerSerializationProvider provider) {}
	public abstract virtual object CreateInstance(Type type, System.Collections.ICollection arguments, string name, bool addToContainer) {}
	public abstract virtual object GetInstance(string name) {}
	public abstract virtual string GetName(object value) {}
	public abstract virtual object GetSerializer(Type objectType, Type serializerType) {}
	public abstract virtual Type GetType(string typeName) {}
	public abstract virtual void RemoveSerializationProvider(IDesignerSerializationProvider provider) {}
	public abstract virtual void ReportError(object errorInformation) {}
	public abstract virtual void SetName(object instance, string name) {}

	// Properties
	public ContextStack Context { get{} }
	public System.ComponentModel.PropertyDescriptorCollection Properties { get{} }

	// Events
	public event System.ComponentModel.Design.Serialization.ResolveNameEventHandler ResolveName;
	public event System.EventHandler SerializationComplete;
}

