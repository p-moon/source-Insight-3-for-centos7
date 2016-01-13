public class Formatter : IFormatter
{

	// Methods
	public abstract virtual object Deserialize(System.IO.Stream serializationStream) {}
	public abstract virtual void Serialize(System.IO.Stream serializationStream, object graph) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ISurrogateSelector SurrogateSelector { get{} set{} }
	public SerializationBinder Binder { get{} set{} }
	public StreamingContext Context { get{} set{} }
}

