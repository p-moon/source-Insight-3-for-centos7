public interface ISerializable
{

	// Methods
	public abstract virtual void GetObjectData(SerializationInfo info, StreamingContext context) {}
}

