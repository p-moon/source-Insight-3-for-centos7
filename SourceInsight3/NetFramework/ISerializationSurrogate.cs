public interface ISerializationSurrogate
{

	// Methods
	public abstract virtual void GetObjectData(object obj, SerializationInfo info, StreamingContext context) {}
	public abstract virtual object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) {}
}

