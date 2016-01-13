public interface IRemotingFormatter : System.Runtime.Serialization.IFormatter
{

	// Methods
	public abstract virtual object Deserialize(System.IO.Stream serializationStream, HeaderHandler handler) {}
	public abstract virtual void Serialize(System.IO.Stream serializationStream, object graph, Header[] headers) {}
}

