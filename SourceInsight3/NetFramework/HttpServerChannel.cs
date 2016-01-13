public class HttpServerChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiverHook
{

	// Constructors
	public HttpServerChannel() {}
	public HttpServerChannel(int port) {}
	public HttpServerChannel(string name, int port) {}
	public HttpServerChannel(string name, int port, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) {}
	public HttpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) {}

	// Methods
	public virtual string Parse(string urlout , System.String& objectURI) {}
	public string GetChannelUri() {}
	public virtual string[] GetUrlsForUri(string objectUri) {}
	public virtual void StartListening(object data) {}
	public virtual void StopListening(object data) {}
	public virtual void AddHookChannelUri(string channelUri) {}
	public virtual bool Contains(object key) {}
	public virtual void Add(object key, object value) {}
	public virtual void Clear() {}
	public virtual void Remove(object key) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ChannelPriority { get{} }
	public string ChannelName { get{} }
	public object ChannelData { get{} }
	public string ChannelScheme { get{} }
	public bool WantsToListen { get{} set{} }
	public System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get{} }
	public object Item { get{} set{} }
	public System.Collections.ICollection Keys { get{} }
	public System.Collections.IDictionary Properties { get{} }
	public System.Collections.ICollection Values { get{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsSynchronized { get{} }
}

