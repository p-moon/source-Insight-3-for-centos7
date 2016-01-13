public class WebEventProvider : System.Configuration.Provider.ProviderBase
{

	// Methods
	public abstract virtual void ProcessEvent(WebBaseEvent raisedEvent) {}
	public abstract virtual void Shutdown() {}
	public abstract virtual void Flush() {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string Description { get{} }
}

