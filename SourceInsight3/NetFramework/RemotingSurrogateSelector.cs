public class RemotingSurrogateSelector : System.Runtime.Serialization.ISurrogateSelector
{

	// Constructors
	public RemotingSurrogateSelector() {}

	// Methods
	public void SetRootObject(object obj) {}
	public object GetRootObject() {}
	public virtual void ChainSelector(System.Runtime.Serialization.ISurrogateSelector selector) {}
	public virtual System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(Type type, System.Runtime.Serialization.StreamingContext contextout , System.Runtime.Serialization.ISurrogateSelector& ssout) {}
	public virtual System.Runtime.Serialization.ISurrogateSelector GetNextSelector() {}
	public virtual void UseSoapFormat() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MessageSurrogateFilter Filter { get{} set{} }
}

