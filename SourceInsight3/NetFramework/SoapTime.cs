public class SoapTime : ISoapXsd
{

	// Constructors
	public SoapTime() {}
	public SoapTime(System.DateTime value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapTime Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public System.DateTime Value { get{} set{} }
}

