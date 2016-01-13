public interface IDesignerSerializationService
{

	// Methods
	public abstract virtual System.Collections.ICollection Deserialize(object serializationData) {}
	public abstract virtual object Serialize(System.Collections.ICollection objects) {}
}

