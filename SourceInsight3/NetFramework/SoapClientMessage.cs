public class SoapClientMessage : SoapMessage
{

	// Methods
	public object GetInParameterValue(int index) {}
	public object GetOutParameterValue(int index) {}
	public object GetReturnValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool OneWay { get{} }
	public SoapHttpClientProtocol Client { get{} }
	public LogicalMethodInfo MethodInfo { get{} }
	public string Url { get{} }
	public string Action { get{} }
	public SoapProtocolVersion SoapVersion { get{} }
	public SoapException Exception { get{} set{} }
	public SoapHeaderCollection Headers { get{} }
	public System.IO.Stream Stream { get{} }
	public string ContentType { get{} set{} }
	public string ContentEncoding { get{} set{} }
	public SoapMessageStage Stage { get{} }
}

