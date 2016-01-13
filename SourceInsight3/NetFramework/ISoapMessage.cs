public interface ISoapMessage
{

	// Properties
	public string[] ParamNames { get{} set{} }
	public object[] ParamValues { get{} set{} }
	public Type[] ParamTypes { get{} set{} }
	public string MethodName { get{} set{} }
	public string XmlNameSpace { get{} set{} }
	public System.Runtime.Remoting.Messaging.Header[] Headers { get{} set{} }
}

