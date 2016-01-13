public interface ISurrogateSelector
{

	// Methods
	public abstract virtual void ChainSelector(ISurrogateSelector selector) {}
	public abstract virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext contextout , ISurrogateSelector& selector) {}
	public abstract virtual ISurrogateSelector GetNextSelector() {}
}

