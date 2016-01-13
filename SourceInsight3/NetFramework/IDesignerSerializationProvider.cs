public interface IDesignerSerializationProvider
{

	// Methods
	public abstract virtual object GetSerializer(IDesignerSerializationManager manager, object currentSerializer, Type objectType, Type serializerType) {}
}

