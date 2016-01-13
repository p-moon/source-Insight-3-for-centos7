public class SoapFault : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public SoapFault() {}
	public SoapFault(string faultCode, string faultString, string faultActor, ServerFault serverFault) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FaultCode { get{} set{} }
	public string FaultString { get{} set{} }
	public string FaultActor { get{} set{} }
	public object Detail { get{} set{} }
}

