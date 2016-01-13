public class SoapFormatter : System.Runtime.Remoting.Messaging.IRemotingFormatter, System.Runtime.Serialization.IFormatter
{

	// Constructors
	public SoapFormatter() {}
	public SoapFormatter(System.Runtime.Serialization.ISurrogateSelector selector, System.Runtime.Serialization.StreamingContext context) {}

	// Methods
	public virtual object Deserialize(System.IO.Stream serializationStream) {}
	public virtual object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) {}
	public virtual void Serialize(System.IO.Stream serializationStream, object graph) {}
	public virtual void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Runtime.Serialization.Formatters.ISoapMessage TopObject { get{} set{} }
	public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get{} set{} }
	public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get{} set{} }
	public System.Runtime.Serialization.Formatters.TypeFilterLevel FilterLevel { get{} set{} }
	public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get{} set{} }
	public System.Runtime.Serialization.SerializationBinder Binder { get{} set{} }
	public System.Runtime.Serialization.StreamingContext Context { get{} set{} }
}

