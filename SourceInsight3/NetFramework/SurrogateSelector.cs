public class SurrogateSelector : ISurrogateSelector
{

	// Constructors
	public SurrogateSelector() {}

	// Methods
	public virtual void AddSurrogate(Type type, StreamingContext context, ISerializationSurrogate surrogate) {}
	public virtual void ChainSelector(ISurrogateSelector selector) {}
	public virtual ISurrogateSelector GetNextSelector() {}
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext contextout , ISurrogateSelector& selector) {}
	public virtual void RemoveSurrogate(Type type, StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

