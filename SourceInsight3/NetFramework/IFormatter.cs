public interface IFormatter
{

	// Methods
	public abstract virtual object Deserialize(System.IO.Stream serializationStream) {}
	public abstract virtual void Serialize(System.IO.Stream serializationStream, object graph) {}

	// Properties
	public ISurrogateSelector SurrogateSelector { get{} set{} }
	public SerializationBinder Binder { get{} set{} }
	public StreamingContext Context { get{} set{} }
}

