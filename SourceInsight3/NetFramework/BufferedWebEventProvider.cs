public class BufferedWebEventProvider : WebEventProvider
{

	// Methods
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public virtual void ProcessEvent(WebBaseEvent eventRaised) {}
	public virtual void Flush() {}
	public virtual void Shutdown() {}
	public abstract virtual void ProcessEventFlush(WebEventBufferFlushInfo flushInfo) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UseBuffering { get{} }
	public string BufferMode { get{} }
	public string Name { get{} }
	public string Description { get{} }
}

