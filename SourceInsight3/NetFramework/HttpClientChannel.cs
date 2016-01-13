public class HttpClientChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.ISecurableChannel
{

	// Constructors
	public HttpClientChannel() {}
	public HttpClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) {}
	public HttpClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) {}

	// Methods
	public virtual string Parse(string urlout , System.String& objectURI) {}
	public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelDataout , System.String& objectURI) {}
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
	public bool IsSecured { get{} set{} }
	public int ChannelPriority { get{} }
	public string ChannelName { get{} }
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

